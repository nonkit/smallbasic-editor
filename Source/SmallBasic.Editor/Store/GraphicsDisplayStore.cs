﻿// <copyright file="GraphicsDisplayStore.cs" company="MIT License">
// Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

namespace SmallBasic.Editor.Store
{
    using System;
    using Microsoft.AspNetCore.Blazor;
    using SmallBasic.Editor.Components;
    using SmallBasic.Editor.Components.Display;
    using SmallBasic.Editor.Libraries;
    using SmallBasic.Utilities;

    internal delegate void KeyEventSignature(string key);

    internal delegate void MouseEventSignature(decimal x, decimal y);

    internal delegate void MouseButtonEventSignature(decimal x, decimal y, MouseButton button);

    internal enum MouseButton
    {
        Left,
        Middle,
        Right,
    }

    internal static class GraphicsDisplayStore
    {
        private static GraphicsDisplay display;

        public static event KeyEventSignature KeyDown;

        public static event KeyEventSignature KeyUp;

        public static event MouseEventSignature MouseMove;

        public static event MouseButtonEventSignature MouseDown;

        public static event MouseButtonEventSignature MouseUp;

        public static decimal LocationX { get; private set; }

        public static decimal LocationY { get; private set; }

        public static ElementRef RenderArea
        {
            get
            {
                if (display.IsDefault() || display.RenderArea.IsDefault())
                {
                    throw new NullReferenceException("Graphics display is not initialized yet");
                }

                return display.RenderArea;
            }
        }

        public static TimeSpan NextAnimationTime
        {
            get
            {
                if (display.IsDefault())
                {
                    return default;
                }

                return display.NextAnimationTime;
            }
        }

        public static void SetDisplay(GraphicsDisplay instance)
        {
            display = instance;
        }

        public static void UpdateDisplay()
        {
            if (!display.IsDefault())
            {
                display.Update();
            }
        }

        public static void UpdateDisplayLocation(decimal x, decimal y)
        {
            LocationX = x;
            LocationY = y;
        }

        public static void SetVisibility(bool value)
        {
            if (!display.IsDefault())
            {
                display.IsVisible = value;
                display.Update();
            }
        }

        public static void SetMouseVisibility(bool value)
        {
            if (!display.IsDefault())
            {
                display.IsMouseVisible = value;
                display.Update();
            }
        }

        public static void NotifyKeyDown(string key)
        {
            if (!KeyDown.IsDefault())
            {
                KeyDown(key);
            }
        }

        public static void NotifyKeyUp(string key)
        {
            if (!KeyUp.IsDefault())
            {
                KeyUp(key);
            }
        }

        public static void NotifyMouseMove(decimal x, decimal y)
        {
            if (!MouseMove.IsDefault())
            {
                MouseMove(x, y);
            }
        }

        public static void NotifyMouseUp(decimal x, decimal y, MouseButton button)
        {
            if (!MouseUp.IsDefault())
            {
                MouseUp(x, y, button);
            }
        }

        public static void NotifyMouseDown(decimal x, decimal y, MouseButton button)
        {
            if (!MouseDown.IsDefault())
            {
                MouseDown(x, y, button);
            }
        }
    }
}
