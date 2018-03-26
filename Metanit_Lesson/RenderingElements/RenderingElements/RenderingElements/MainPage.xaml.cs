using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RenderingElements
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Content = new HeaderView();
        }


        private void ChangeText(object sender, EventArgs e)
        {
            //HeaderView hView = sender as HeaderView;
            //hView.Text = $"{++clicks} clicks";
        }
    }
}
