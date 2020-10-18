using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WhatSize
{
    struct FontCalc
    {
        public FontCalc(Label label, double fontSize, double containerWidth)
            : this()
        {
            // Save the font size.
            FontSize = fontSize;

            // Recalculate the Label height.
            label.FontSize = fontSize;
            SizeRequest sizeRequest = label.Measure(containerWidth, Double.PositiveInfinity);

            // Save that height.
            TextHeight = sizeRequest.Request.Height;
        }

        public double FontSize { private set; get; }

        public double TextHeight { private set; get; }
    }
}
