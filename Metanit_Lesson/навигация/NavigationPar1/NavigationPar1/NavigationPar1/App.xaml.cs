using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NavigationPar1
{
    public partial class App : Application
    {
        /*
         * Но чтобы с MainPage можно было бы переходить к CommonPage или ModalPage, 
         * нам надо в качестве главной страницы использовать объект NavigationPage, 
         * а не ContentPage, как установлено по умолчанию. 
         * Поэтому перейдем к классу App и изменим код установки главной страницы:
         * */
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()); 
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
