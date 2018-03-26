using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ExampleAppMVVM.Models;
using ExampleAppMVVM.Views;
namespace ExampleAppMVVM.ViewModels
{
    /// <summary>
    /// Класс осуществляющий связь между моделью данных и представлениями
    /// </summary>
   public class FriendViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие которое происходит при изменении свойств объекта
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        FriendsListViewModel lvm;   //экземпляр класса
        public Friend Friend { get; private set; }  //объект класса Friend
        public FriendViewModel()
        {
            Friend = new Friend();
        }

        /// <summary>
        /// Свойство для доступа к FriendsListViewModel
        /// </summary>
        public FriendsListViewModel ListViewModel
        {
            get
            {
                return lvm;
            }

            set
            {
                if(lvm!=value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        /// <summary>
        /// свойство для доступа к Name
        /// </summary>
        public string Name
        {
            get { return Friend.Name; }
            set
            {
                if (Friend.Name != value)
                {
                    Friend.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// свойство для доступа к полю Email
        /// </summary>
        public string Email
        {
            get { return Friend.Email; }
            set
            {
                if (Friend.Email != value)
                {
                    Friend.Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        /// <summary>
        /// свойство для доступа к полю Phone
        /// </summary>
        public string Phone
        {
            get { return Friend.Phone; }
            set
            {
                if (Friend.Phone != value)
                {
                    Friend.Phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }


        /// <summary>
        /// свойсто проверки полей на ноль
        /// </summary>
        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                    (!string.IsNullOrEmpty(Phone.Trim())) ||
                    (!string.IsNullOrEmpty(Email.Trim())));
            }
        }


        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }



    }
}
