using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClicksOnButtons
{
    public partial class MainPage : ContentPage
    {
        protected internal int count = 0;
        int c1 = 0;
        public MainPage()
        {
            InitializeComponent();
            Button2.Clicked += Button2_Clicked;     //второй способ подписания на события
            Button3.Clicked += (s, e) =>
              {
                  int k = 0;
                  if(Int32.TryParse(Button3.Text,out k))
                  {
                      Button3.Text = Convert.ToString(k + 100);
                  }
                  else
                  {
                      Button3.Text = "0";
                  }
              };                //Третий способ подписания на события
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            c1 += 10;
            Button2.Text = Convert.ToString(c1);
        }

        private void Button1_Click(object sendler,EventArgs e)
        {
            count++;
            Button1.Text = Convert.ToString(count);

        }
    }
}
