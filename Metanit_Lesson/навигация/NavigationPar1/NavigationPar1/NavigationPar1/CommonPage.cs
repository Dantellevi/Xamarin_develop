using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NavigationPar1
{

    /*
     * На этой странице определяется единственная кнопка, 
     * по нажатию на которую осуществляется переход назад с 
     * помощью метода Navigation.PopAsync(). Поскольку метод 
     * является асинхронным, то перед ним ставится ключевое слово await,
     *  а сам обработчик кнопки помечается с помощью ключевого слова async.
     * */
    public class CommonPage : ContentPage
    {
        public CommonPage()
        {
            Title = "Common Page";
            Button backButton = new Button
            {
                Text = "Назад",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            backButton.Clicked += BackButton_Clicked;
            Content = backButton;
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}
