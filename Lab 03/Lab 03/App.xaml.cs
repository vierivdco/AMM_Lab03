﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab_03
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridCode();
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