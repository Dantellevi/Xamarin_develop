using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DatePicker
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OnDateSelected(object sendler,DateChangedEventArgs e)
        {
            txtDateTime.Text = e.NewDate.ToString();
        }
    }
}
