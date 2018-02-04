using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace progress_Bar_Example
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            myprogressBar.ProgressTo(0.5, 500, Easing.Linear);
        }
    }
}
