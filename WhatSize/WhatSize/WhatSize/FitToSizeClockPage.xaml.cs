﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatSize
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FitToSizeClockPage : ContentPage
    {
        public FitToSizeClockPage()
        {
            Label clockLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Content = clockLabel;

            // Handle the SizeChanged event for the page.
            SizeChanged += (object sender, EventArgs args) =>
              {
                // Scale the font size to the page width
                // (based on 11 characters in the displayed string).
                if (this.Width > 0)
                      clockLabel.FontSize = this.Width / 6;
              };

            // Start the timer going.
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                // Set the Text property of the Label.
                clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
                return true;
            });
        }
    }
}