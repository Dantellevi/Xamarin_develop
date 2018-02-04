using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListView
{
    public partial class PageListViewDataBindingExample : ContentPage
    {
        public PageListViewDataBindingExample()
        {

            List<phone> phones = null;
            InitializeComponent();

            

            phones = new List<phone>()
            {
            new phone {Title="Galaxy S8", Company="Samsung", Price=48000 },
            new phone {Title="Huawei P10", Company="Huawei", Price=35000 },
            new phone {Title="HTC U Ultra", Company="HTC", Price=42000 },
            new phone {Title="iPhone 7", Company="Apple", Price=52000 }
            };



            listView.HasUnevenRows = true;
            //-----------------------------------------------
            // Определяем источник данных
            listView.ItemsSource = phones;
            //-----------------------------------------------
            // Определяем формат отображения данных
            listView.ItemTemplate = new DataTemplate(() => {
                // привязка к свойству Name
                Label titleLabel = new Label { FontSize = 18 };
                titleLabel.SetBinding(Label.TextProperty, "Title");

                // привязка к свойству Company
                Label companyLabel = new Label();
                companyLabel.SetBinding(Label.TextProperty, "Company");

                // привязка к свойству Price
                Label priceLabel = new Label();
                priceLabel.SetBinding(Label.TextProperty, "Price");

                // создаем объект ViewCell.
                return new ViewCell
                {
                    View = new StackLayout
                    {
                        Padding = new Thickness(0, 5),
                        Orientation = StackOrientation.Vertical,
                        Children = { titleLabel, companyLabel, priceLabel }
                    }
                };
            });


            /*
             * 
  * public class Phone
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }
     
    public partial class MainPage : ContentPage
    {
        public List<Phone> Phones { get; set; }
 
        public MainPage()
        {
            InitializeComponent();
            Phones = new List<Phone>
            {
                new Phone {Title="Galaxy S8", Company="Samsung", Price=48000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=35000 },
                new Phone {Title="HTC U Ultra", Company="HTC", Price=42000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=52000 }
            };
            this.BindingContext = this;
        }
        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Phone selectedPhone = e.Item as Phone;
            if (selectedPhone != null)
                await DisplayAlert("Выбранная модель", $"{selectedPhone.Company} - {selectedPhone.Title}", "OK");
        }
             * 
             * */

            /*
             * ==================================== определим класс страницы, которая будет выводить эти изображения через ImageCell===================
             * 
             * Phones = new List<Phone>
            {
                new Phone {Title="Galaxy S8", Company="Samsung", Price=48000, ImagePath="galaxys6.jpg" },
                new Phone {Title="Huawei P10", Company="Huawei", Price=35000, ImagePath="mate8.jpg" },
                new Phone {Title="HP Elite z3", Company="HP", Price=42000, ImagePath="lumia950.jpg" },
                new Phone {Title="LG G 6", Company="LG", Price=42000, ImagePath="nexus5x.jpg" },
                new Phone {Title="iPhone 7", Company="Apple", Price=52000, ImagePath="iphone6s.jpg" }
            };
            Label header = new Label
            {
                Text = "Список моделей",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            ListView listView = new ListView
            {
                HasUnevenRows = true,
                ItemsSource = Phones,
                // Определяем формат отображения данных
                ItemTemplate = new DataTemplate(() =>
                {
                    ImageCell imageCell = new ImageCell { TextColor = Color.Red, DetailColor = Color.Green };
                    imageCell.SetBinding(ImageCell.TextProperty, "Title");
                    Binding companyBinding = new Binding { Path = "Company", StringFormat="Флагман от компании {0}"};
                    imageCell.SetBinding(ImageCell.DetailProperty, companyBinding);
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "ImagePath");
                    return imageCell;
                })
            };
            listView.ItemTapped += OnItemTapped;
            this.Content = new StackLayout { Children = { header, listView } };
        }


             * */



            /*
             * ==============================Создание собственной ячейкив ListView=================
             * public MainPage()
        {
            Phones = new List<Phone>
            {
                new Phone {Title="Galaxy S8", Company="Samsung", Price=48000, ImagePath="galaxys6.jpg" },
                new Phone {Title="Huawei P10", Company="Huawei", Price=35000, ImagePath="mate8.jpg" },
                new Phone {Title="HP Elite z3", Company="HP", Price=42000, ImagePath="lumia950.jpg" },
                new Phone {Title="LG G 6", Company="LG", Price=42000, ImagePath="nexus5x.jpg" },
                new Phone {Title="iPhone 7", Company="Apple", Price=52000, ImagePath="iphone6s.jpg" }
            };
            Label header = new Label
            {
                Text = "Список моделей",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
             
            ListView listView = new ListView
            {
                HasUnevenRows = true,
                ItemsSource = Phones,
                 
                ItemTemplate = new DataTemplate(() =>
                {
                    CustomCell customCell = new CustomCell { ImageHeight=60, ImageWidth=45 };
                    customCell.SetBinding(CustomCell.TitleProperty, "Title");
                    Binding companyBinding = new Binding { Path = "Company", StringFormat = "Флагман от компании {0}" };
                    customCell.SetBinding(CustomCell.DetailProperty, companyBinding);
                    customCell.SetBinding(CustomCell.ImagePathProperty, "ImagePath");
                    return customCell;
                })
            };
            this.Content = new StackLayout { Children = { header, listView } };
        }
    }
    public class Phone
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }
             * 
             * 
             * 
             * */



            /*
             * ==================================ObservableCollection=============================
             * using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
 
namespace HelloApp
{
    public partial class MainPage : ContentPage
    {
        public List<Phone> Phones { get; set; }
 
        public MainPage()
        {
            InitializeComponent();
            Phones = new List<Phone>
            {
                new Phone { Title = "HTC U Ultra", Company = "HTC", Price = 36000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=35000 },
                new Phone {Title="LG G 6", Company="LG", Price=42000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=52000 }
            };
 
            this.BindingContext = this;
        }
        // добавление объекта
        private void AddItem(object sender, EventArgs e)
        {
            Phones.Add(new Phone { Title = "Galaxy S8", Company = "Samsung", Price = 48000 });
        }
        // удаление выделенного объекта
        private void RemoveItem(object sender, EventArgs e)
        {
            Phone phone = phonesList.SelectedItem as Phone;
            if (phone != null)
            {
                Phones.Remove(phone);
                phonesList.SelectedItem = null;
            }
        }
    }
 
    public class Phone
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }
}



            В данном случае типом коллекции является стандартный класс List, 
            который поддерживает добавление и удаление с помощью методов Add() 
            и Remove(). Однако при запуске приложения, если мы будем нажимать на кнопки, 
            то никаких изменений в ListView, который отображает данный список, мы не увидим. 
            Хотя в реальности коллекция Phones будет изменяться. Более того, мы можем столкнуться 
            с исключением.

            Чтобы решить эту проблемы в качестве типа коллекции, как правило, используется 
            не класс List, а класс ObservableCollection из пространства имен 
            System.Collections.ObjectModel. За счет реализации интерфейса INotifyCollectionChanged 
            при добавлении или удалении объектов в ObservableCollection автоматически будут изменяться 
            все привязанные к этой коллекции объекты, в том числе и ListView.

Итак, изменим определение коллекции Phones:
             * 
             * 
             * public ObservableCollection<Phone> Phones { get; set; }
public MainPage()
{
    InitializeComponent();
    Phones = new ObservableCollection<Phone>
    {
        new Phone { Title = "HTC U Ultra", Company = "HTC", Price = 36000 },
        new Phone {Title="Huawei P10", Company="Huawei", Price=35000 },
        new Phone {Title="LG G 6", Company="LG", Price=42000 },
        new Phone {Title="iPhone 7", Company="Apple", Price=52000 }
    };
    this.BindingContext = this;
}
             * */


        }
    }
}
