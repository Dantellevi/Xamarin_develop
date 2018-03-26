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
    /// Класс для вывода списка друзей
    /// </summary>
    public partial class FriendPage : ContentPage
    {

        /*
         * Теперь страница в качестве параметра в 
         * конструкторе принимает объект 
         * FriendViewModel, устанавливает его в 
         * качестве контекста и также не содержит 
         * никакой другой логики.
         * */

        public FriendViewModel ViewModel { get; private set; }
        public FriendPage(FriendViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;

        }
    }
}
