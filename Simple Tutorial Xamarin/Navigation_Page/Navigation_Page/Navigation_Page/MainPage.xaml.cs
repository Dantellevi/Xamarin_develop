﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigation_Page
{
    public partial class MainPage : ContentPage
    {

       
        public MainPage()
        {
            InitializeComponent();
        }


        private async void But1_Click(object sendler,EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
