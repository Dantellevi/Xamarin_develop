using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TelephoneApp
{
	public partial class MainPage : ContentPage
	{
        Entry phoneNumberEntry;
        Button callButton;
        public MainPage()
		{
			InitializeComponent();

            Title = "Телефон";
            phoneNumberEntry = new Entry { Placeholder = "Введите номер" };
            callButton = new Button { Text = "Call" };
            callButton.Clicked += async (o, e) =>
            {
                await DependencyService.Get<IPhone>()?.Call(phoneNumberEntry.Text);
            };

            Content = new StackLayout
            {
                Children = { phoneNumberEntry, callButton }
            };
        }
	}
}
