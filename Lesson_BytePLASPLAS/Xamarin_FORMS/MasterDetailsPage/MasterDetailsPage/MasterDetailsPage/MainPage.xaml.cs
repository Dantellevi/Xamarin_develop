using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailsPage
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new PageNews()) {
                BarBackgroundColor = Color.FromHex("#008000")
            };
            IsPresented = true;
        }



        private void But_1_click(object sendler,EventArgs e)
        {
            Detail = new NavigationPage(new PageFriends())
            {
                BarBackgroundColor = Color.FromHex("#008000")
            };
            IsPresented = false;
        }

        private void But_2_click(object sendler,EventArgs e)
        {
            Detail = new NavigationPage(new PageNews())
            {
                BarBackgroundColor = Color.FromHex("#008000")
            };
            IsPresented = false;
        }
    }
}
