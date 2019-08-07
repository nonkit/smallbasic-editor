﻿// <copyright file="NetworkBridge.cs" company="MIT License">
// Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

namespace SmallBasic.Bridge
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using SmallBasic.Utilities.Bridge;

    internal class NetworkBridge : INetworkBridge
    {
        public ImageListBridgeModels.ImageData LoadImage(string fileNameOrUrl)
        {
            if (new Uri(fileNameOrUrl).IsFile)
            {
                return CreateImage(() => File.ReadAllBytes(fileNameOrUrl));
            }
            else
            {
                using (var client = new WebClient())
                {
                    return CreateImage(() => client.DownloadData(fileNameOrUrl));
                }
            }
        }

        public string DownloadFile(string url)
        {
            try
            {
                using (var client = new WebClient())
                {
                    string path = Path.GetTempFileName();
                    File.WriteAllText(path, client.DownloadString(url));
                    return path;
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        public string GetWebPageContents(string url)
        {
            try
            {
                using (var client = new WebClient())
                {
                    return client.DownloadString(url);
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        private static ImageListBridgeModels.ImageData CreateImage(Func<byte[]> factory)
        {
            try
            {
                byte[] bytes = factory();
                using (var stream = new MemoryStream(bytes))
                {
                    using (var image = new Bitmap(Image.FromStream(stream)))
                    {
                        string base64Contents = Convert.ToBase64String(bytes, Base64FormattingOptions.None);
                        return new ImageListBridgeModels.ImageData(image.Width, image.Height, base64Contents);
                    }
                }
            }
            catch
            {
                return new ImageListBridgeModels.ImageData(width: 0, height: 0, base64Contents: string.Empty);
            }
        }
    }
}
