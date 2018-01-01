﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App_CrossPlatformed
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new App_CrossPlatformed.MainPage();
            //MainPage = new StartPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}