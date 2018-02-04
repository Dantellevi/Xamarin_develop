using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NavigationPar1
{
    /*
     * Данная страница выглядит во многом аналогично предыдущий за тем исключением, 
     * что переход назад здесь производится с помощью метода Navigation.PopModalAsync(). 
     * То есть эта страница будет модальной.
     * */
    public class ModalPage : ContentPage
    {
        public ModalPage()
        {
            Title = "Модальное окно";
            Button backButton = new Button
            {
                Text = "Назад",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions=LayoutOptions.Center
                
            };
            backButton.Clicked += BackButton_Clicked;
            Content = backButton;
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
