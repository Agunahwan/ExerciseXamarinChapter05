using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatSize
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MetricalBoxViewPage : ContentPage
    {
        public MetricalBoxViewPage()
        {
            Content = new BoxView
            {
                Color = Color.Accent,
                WidthRequest = 64,
                HeightRequest = 160,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
        }
    }
}