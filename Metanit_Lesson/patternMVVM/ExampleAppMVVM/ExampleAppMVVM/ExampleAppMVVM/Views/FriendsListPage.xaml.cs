using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleAppMVVM.ViewModels;
using Xamarin.Forms;

namespace ExampleAppMVVM.Views
{
    /// <summary>
    /// класс для управления одним другом
    /// </summary>
    public partial class FriendsListPage : ContentPage
    {
        public FriendsListPage()
        {
            InitializeComponent();
            /*
             *Здесь создается объект FriendsListViewModel, который устанавливается в качестве контекста страницы. 
             * */

            BindingContext = new FriendsListViewModel() { Navigation = this.Navigation };
        }
    }
}
