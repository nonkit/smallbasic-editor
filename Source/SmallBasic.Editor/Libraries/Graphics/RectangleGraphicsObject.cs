﻿// <copyright file="RectangleGraphicsObject.cs" company="MIT License">
// Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

namespace SmallBasic.Editor.Libraries.Graphics
{
    using System.Collections.Generic;
    using System.Globalization;
    using SmallBasic.Editor.Components;
    using SmallBasic.Editor.Libraries.Utilities;

    internal sealed class RectangleGraphicsObject : BaseGraphicsObject
    {
        public RectangleGraphicsObject(decimal x, decimal y, decimal width, decimal height, GraphicsWindowStyles styles)
            : base(styles)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        public decimal X { get; set; }

        public decimal Y { get; set; }

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public override void ComposeTree(TreeComposer composer)
        {
            composer.Element(
                name: "rect",
                styles: new Dictionary<string, string>
                {
                    { "fill", this.Styles.BrushColor },
                    { "stroke", this.Styles.PenColor },
                    { "stroke-width", $"{this.Styles.PenWidth}px" },
                },
                attributes: new Dictionary<string, string>
                {
                    { "x", this.X.ToString(CultureInfo.CurrentCulture) },
                    { "y", this.Y.ToString(CultureInfo.CurrentCulture) },
                    { "width", this.Width.ToString(CultureInfo.CurrentCulture) },
                    { "height", this.Height.ToString(CultureInfo.CurrentCulture) },
                });
        }
    }
}
