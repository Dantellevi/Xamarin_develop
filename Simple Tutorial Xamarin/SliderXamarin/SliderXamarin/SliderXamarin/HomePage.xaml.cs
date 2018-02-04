using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SliderXamarin
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }


        private void mySlider_ValueChanged(object sendler,ValueChangedEventArgs e)
        {
            txtResult.Text = "Значение слайдера:" + mySlider.Value;
        }
    }
}
