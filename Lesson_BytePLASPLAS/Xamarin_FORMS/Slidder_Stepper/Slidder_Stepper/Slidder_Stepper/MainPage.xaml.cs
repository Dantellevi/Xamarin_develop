using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Slidder_Stepper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            editor1.FontSize = Slider1.Value;
        }

        private void Slider1_valueChanged(object sendler,ValueChangedEventArgs e)
        {
            if(e.NewValue>0)
            {
                editor1.FontSize = e.NewValue;
                stepper1.Value = e.NewValue;
            }
        }


        private void stepper1_valueChanged(object sendler, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                editor1.FontSize = e.NewValue;
                Slider1.Value = e.NewValue;

            }
        }
    }
}
