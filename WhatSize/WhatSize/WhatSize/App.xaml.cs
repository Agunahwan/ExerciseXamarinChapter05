﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatSize
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new WhatSizePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}