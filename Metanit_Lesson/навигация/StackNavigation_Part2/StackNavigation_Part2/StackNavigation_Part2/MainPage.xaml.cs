using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackNavigation_Part2
{
    /*
     * На этой странице определяется кнопка для перехода вперед к странице 
     * Page2 и метка, в которую выводится текущее содержимое из NavigationStack.

        Прежде всего здесь надо отметить метод DisplayStack(), 
        который выводит все содержимое стека NavigationStack. Хотя в каждой 
        странице мы нам напрямую доступно свойство Navigation.NavigationStack, 
        однако это будет не общий стек, а стек, ассоциированный непосредственно 
        с текущей страницей. Более того на момент использования по умолчанию он 
        будет иметь 0 элементов. И чтобы получить общий стек, нам надо 
        обратиться к NavigationPage:
     * */
    public partial class MainPage : ContentPage
    {
        Label stackLabel;
        bool loaded = false;
        public MainPage()
        {
            InitializeComponent();
            Button forwardButton = new Button { Text = "Вперед" };
            forwardButton.Clicked += ForwardButton_Clicked;

            stackLabel = new Label();
            Content = new StackLayout { Children = { forwardButton, stackLabel } };

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (loaded == false)
            {
                DisplayStack();
                loaded = true;
            }
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

        private async void ForwardButton_Clicked(object sender, EventArgs e)
        {
            Page2 page = new Page2();
            await Navigation.PushAsync(page);
            page.DisplayStack();
        }
    }
}
