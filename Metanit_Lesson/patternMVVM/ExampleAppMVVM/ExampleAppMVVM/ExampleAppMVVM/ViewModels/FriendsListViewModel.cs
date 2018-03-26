using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using ExampleAppMVVM.Models;
using ExampleAppMVVM.Views;

namespace ExampleAppMVVM.ViewModels
{
    /// <summary>
    /// класс который представляет список друзей и который будет использоваться на странице FriendsListPage
    /// </summary>
   public class FriendsListViewModel : INotifyPropertyChanged
    {

        /// <summary>
        /// Динамический список друзей который будет самообновляться при изменении свойств
        /// </summary>
        public ObservableCollection<FriendViewModel> Friends { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        #region Commands
        /*
         * Для управлением списком друзей в классе 
         * определено четыре команды. Команда добавления 
         * нового друга приводит в действие метод 
         * CreateFriend(), в котором производится переход 
         * к FriendPage. В конструктор FriendPage передается 
         * текущий объект FriendPageViewModel, который мы 
         * далее создадим.

        По команде возвращения назад выполняется метод Back(),
        который производит переход назад.

        Команда сохранения объекта выполняет метод 
        SaveFriend(). В этом методе новый объект добавляется
        в коллекцию Friends.

        По команде удаления вызывается метод DeleteFriend, 
        который удаляет объект из списка.
         * */
        /// <summary>
        /// Реализация команды добавление новго друга
        /// </summary>
        public ICommand CreateFriendCommand { protected set; get; }

        /// <summary>
        /// Реализация команды удаления друга
        /// </summary>
        public ICommand DeleteFriendCommand { protected set; get; }

        /// <summary>
        /// Реализация команды сохранения данных о друге
        /// </summary>
        public ICommand SaveFriendCommand { protected set; get; }
        /// <summary>
        /// Реализация команды отмены команды
        /// </summary>
        public ICommand BackCommand { protected set; get; }


        #endregion

        /// <summary>
        /// Выбранный объект друга
        /// </summary>
        FriendViewModel selectedFriend;

        /// <summary>
        /// Навигация также является частью логики 
        /// приложения, которая не относится к визуальной 
        /// части, поэтому для хранения сервиса навигации 
        /// здесь определено свойство Navigation. 
        /// В дальнейшем через это свойство будет 
        /// производиться переход к FriendPage.
        /// </summary>
        public INavigation Navigation { get; set; }



        public FriendsListViewModel()
        {
            Friends = new ObservableCollection<FriendViewModel>();
            CreateFriendCommand = new Command(CreateFriend);
            DeleteFriendCommand = new Command(DeleteFriend);
            SaveFriendCommand = new Command(SaveFriend);
            BackCommand = new Command(Back);
        }


        /// <summary>
        /// Свойство для доступа к выбранному объекту друга
        /// </summary>
        public FriendViewModel SelectedFriend
        {
            get { return selectedFriend; }
            set
            {
                if (selectedFriend != value)
                {
                    FriendViewModel tempFriend = value;
                    selectedFriend = null;
                    OnPropertyChanged("SelectedFriend");
                    Navigation.PushAsync(new FriendPage(tempFriend));
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }


        /// <summary>
        /// переход на страницу добавления нового друга
        /// </summary>
        private void CreateFriend()
        {
            Navigation.PushAsync(new FriendPage(new FriendViewModel() { ListViewModel = this }));
        }

        /// <summary>
        /// закрытие страницы с добавление 
        /// </summary>
        private void Back()
        {
            Navigation.PopAsync();
        }

        /// <summary>
        /// Обработчик события сохранения данных о модели
        /// </summary>
        /// <param name="friendObject"></param>
        private void SaveFriend(object friendObject)
        {
            FriendViewModel friend = friendObject as FriendViewModel;
            if (friend != null && friend.IsValid)
            {
                Friends.Add(friend);
            }
            Back();
        }
        /// <summary>
        /// Обработчик команды удаление выбранного объекта
        /// </summary>
        /// <param name="friendObject"></param>
        private void DeleteFriend(object friendObject)
        {
            FriendViewModel friend = friendObject as FriendViewModel;
            if (friend != null)
            {
                Friends.Remove(friend);
            }
            Back();
        }





    }
}
