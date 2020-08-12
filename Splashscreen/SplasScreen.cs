﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Splashscreen
{
    [Activity(Label = "Meu SplashScreen", MainLauncher = true, Theme = "@style/Theme.Splash", NoHistory = true)]
    public class SplasScreen : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Thread.Sleep(4000);
            StartActivity(typeof(MainActivity));
        }
    }
}