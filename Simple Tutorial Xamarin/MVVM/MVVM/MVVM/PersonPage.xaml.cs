using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;
using MVVM.Converter;
using Xamarin.Forms;

namespace MVVM
{
    public partial class PersonPage : ContentPage
    {
        public PersonPage()
        {
            InitializeComponent();
            BindingContext = new PersonViewModels();
        }
    }
}
