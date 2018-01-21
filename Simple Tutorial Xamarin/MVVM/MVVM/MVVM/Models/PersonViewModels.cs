using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM.Models
{
   public class PersonViewModels:INotifyPropertyChanged
    {
       
        private string _message;
        private Person _person;
        public Person person {
            get {
                return _person;
            }

            set {
                _person = value;
                OnPropertyChanged();
            } }
        public string Message {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public Command showCommand
        {
            get
            {
                return new Command(() =>
                {
                    Message = "Person show : Name=" + person.Name + "\n";
                });
            }
        }

        public PersonViewModels()
        {
            person = new Person()
            {
                Name="Сания",
                Email="dantel.levi93@gmail.com"
            };

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName=null)

        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
