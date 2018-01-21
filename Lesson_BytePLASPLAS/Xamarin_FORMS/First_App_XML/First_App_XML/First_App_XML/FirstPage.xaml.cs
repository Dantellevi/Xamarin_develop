using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace First_App_XML
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        private void ButtonHello_Click(object sender,EventArgs e)
        {
            Label1.Text = Entry1.Text;
        }
    }
}
