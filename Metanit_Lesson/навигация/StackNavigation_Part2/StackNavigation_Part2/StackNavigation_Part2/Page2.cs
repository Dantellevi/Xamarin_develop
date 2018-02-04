using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace StackNavigation_Part2
{

    /*
     * Здесь определены две кнопки для перехода вперед к Page3 и назад к MainPage. 
     * И также определен метод DisplayStack(), который аналогичен версии в MainPage.

        Переход вперед к Page3 здесь аналогичен переходу к Page2 из MainPage.

        А вот при переходе назад мы получаем страницу которая является последней в стеке 
        (в данном случае MainPage) и вызываем у нее метод DisplayStack.

        Класс NavigationPage определяет свойство CurrentPage. Это свойство указывает на 
        страницу, которая находится последней коллекции NavigationStack.
     * */
    public class Page2 : ContentPage
    {
        Label stackLabel;
        public Page2()
        {
            Title = "Page 2";
            Button forwardBtn = new Button { Text = "Вперед" };
            forwardBtn.Clicked += ForwardBtn_Clicked;
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += BackBtn_Clicked;

            stackLabel = new Label();
            Content = new StackLayout { Children = { forwardBtn, backBtn, stackLabel } };
        }

        protected internal void DisplayStack()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            stackLabel.Text = "";
            foreach (Page p in navPage.Navigation.NavigationStack)
            {
                stackLabel.Text += p.Title + "\n";
            }
        }

        private async void BackBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((MainPage)navPage.CurrentPage).DisplayStack();
        }

        private async void ForwardBtn_Clicked(object sender, EventArgs e)
        {
            Page3 page = new Page3();
            await Navigation.PushAsync(page);
            page.DisplayStack();
        }
    }
}
