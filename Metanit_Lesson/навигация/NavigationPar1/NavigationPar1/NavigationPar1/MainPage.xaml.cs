using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationPar1
{
    public partial class MainPage : ContentPage
    {
        /*
         * Итак, здесь две кнопки. Одна производит переход на CommonPage с помощью метода 
         * Navigation.PushAsync(), 
         * а другая осуществляет переход на ModalPage 
         * посредством вызова Navigation.PushModalAsync()
         * */
        public MainPage()
        {
            InitializeComponent();
            Title = "Main Page";
            Button toCommonPageBtn = new Button
            {
                Text = "На обычную страницу",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            toCommonPageBtn.Clicked += ToCommonPageBtn_Clicked;


            Button toModalPageBtn = new Button
            {
                Text = "На модальную страницу",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            toModalPageBtn.Clicked += ToModalPageBtn_Clicked;

            Content = new StackLayout { Children = { toCommonPageBtn, toModalPageBtn } };
        }

        private async void ToModalPageBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage(),true);
        }

        private async void ToCommonPageBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommonPage(),true);
        }
    }
}
