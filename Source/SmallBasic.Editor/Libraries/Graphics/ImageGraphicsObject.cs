﻿// <copyright file="ImageGraphicsObject.cs" company="MIT License">
// Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

namespace SmallBasic.Editor.Libraries.Graphics
{
    using System.Collections.Generic;
    using System.Globalization;
    using SmallBasic.Editor.Components;
    using SmallBasic.Editor.Libraries.Utilities;

    internal sealed class ImageGraphicsObject : BaseGraphicsObject
    {
        public ImageGraphicsObject(decimal x, decimal y, decimal scaleX, decimal scaleY, string name, GraphicsWindowStyles styles)
            : base(styles)
        {
            this.X = x;
            this.Y = y;
            this.ScaleX = scaleX;
            this.ScaleY = scaleY;
            this.Name = name;
        }

        public decimal X { get; set; }

        public decimal Y { get; set; }

        public decimal ScaleX { get; set; }

        public decimal ScaleY { get; set; }

        public string Name { get; set; }

        public override void ComposeTree(TreeComposer composer)
        {
            composer.Element(
                name: "image",
                attributes: new Dictionary<string, string>
                {
                    { "href", this.Name },
                    { "x", this.X.ToString(CultureInfo.CurrentCulture) },
                    { "y", this.Y.ToString(CultureInfo.CurrentCulture) },
                    { "transform", $"scale({this.ScaleX}, {this.ScaleY})" }
                });
        }
    }
}
