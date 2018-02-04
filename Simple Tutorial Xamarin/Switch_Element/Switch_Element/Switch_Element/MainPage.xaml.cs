using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Switch_Element
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTogged(object sendler,ToggledEventArgs e)
        {
            bool isToogled = e.Value;
            txtResult.Text = isToogled.ToString();

        }
    }
}
