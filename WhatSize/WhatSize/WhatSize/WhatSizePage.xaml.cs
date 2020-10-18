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
    public partial class WhatSizePage : ContentPage
    {
        Label label;

        public WhatSizePage()
        {
            label = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Content = label;

            SizeChanged += OnPageSizeChanged;
        }

        void OnPageSizeChanged(object sender, EventArgs args)
        {
            label.Text = String.Format("{0} \u00D7 {1}", Width, Height);
        }
    }
}