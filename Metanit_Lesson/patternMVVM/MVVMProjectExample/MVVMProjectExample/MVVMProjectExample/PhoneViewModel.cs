using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMProjectExample
{

    /// <summary>
    /// Класс которыйф связывает данные и визуальный интерфейс.позволяет уведомлять систему об изменении его свойств с помощью события PropertyChanged
    /// </summary>
    class PhoneViewModel : INotifyPropertyChanged
    {

        //Реализация команд
        public ICommand SavePhoneCommand { protected set; get; }
        public ICommand DeletePhoneCommand { protected set; get; }

        public event PropertyChangedEventHandler PropertyChanged;
        public Phone phone { get; set; }

        public PhoneViewModel()
        {
            phone = new Phone();
            this.SavePhoneCommand = new Command(SavePhone); //создаем команду
            this.DeletePhoneCommand = new Command(DeletePhone); //создаем команду

        }

        /// <summary>
        ///метод который вызывается командой SavePhoneCommand
        /// </summary>
        private void SavePhone()
        {
            // код по сохранению объекта Phone в бд, внешнем файле и т.д.
        }

        /// <summary>
        /// Метод который вызывается командой DeletePhoneCommand
        /// </summary>
        private void DeletePhone()
        {
            // код по удалению объекта Phone из бд и т.д.
            // в данном примере просто очищаем поля
            this.Title = "";
            this.Company = "";
            this.Price = 0;
        }

        public string Title
        {
            get
            {
                return phone.Title;
            }
            set
            {
                if (phone.Title != value)
                {
                    phone.Title = value;
                    OnPropertyChanged("Title");
                }
                    
            }
        }


        public string Company
        {
            get
            {
                return phone.Company;
            }

            set
            {
                if(phone.Company!=value)
                {
                    phone.Company = value;
                    OnPropertyChanged("Company");
                }
            }
        }

        public int Price
        {
            get { return phone.Price; }
            set
            {
                if (phone.Price != value)
                {
                    phone.Price = value;
                    OnPropertyChanged("Price");
                }
            }
        }



        protected void OnPropertyChanged(string propName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }


        }






    }
}
