using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Display_messege
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }



        private async void btnShow_Clicked(object sendler,EventArgs e)
        {
            string Mess = txtInput.Text;
            var userclick = await DisplayAlert("Ваш текст", Mess, "Go it","No thanks!!");
            if(userclick)
            {
                await DisplayAlert("Go it", "You clicked go it", "OK");
            }

        }

        private async void btnShowAction_Clicked(object sendler, EventArgs e)
        {
            //if Android
            Device.OnPlatform(Android: () =>
            {
                var action = DisplayActionSheet("Share to social?", "Cancel", "Ok", "Facebook", "Google+");
                if(action.Equals("Facebook"))
                {
                    DisplayAlert("Facebook", "Share to Facebook", "OK");

                }
                else if(action.Equals("Google+"))
                {
                    DisplayAlert("Google+", "Share to Google", "OK");
                }
                else
                {
                    return;
                }

            });
        }
    }
}
