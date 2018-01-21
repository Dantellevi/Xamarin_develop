using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elements_compan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label label1 = new Label();             //создаем метку 1
            label1.Text = "Первый текст label1";

            Label label2 = new Label() { Text = "Вторая метка" }; //создаем метку 2


            StackLayout stLay = new StackLayout()               //создаем контейнер для хранения
            {
                Children = { label1, label2 }                   //помещаем контролы в контейнер
            };

            this.Content = stLay;

            //Второй вариант добавления
            //stackLayout.Children.Add(new Label { Text = "Третья метка" });



            //=======================================StackLayout Ориентация внутри контейнера================
            /*
             * StackLayout определяет размещение элементов в виде горизонтального или 
             * вертикального стека. Для позиционирования элементо он определяет два свойства:

                Orientation: определяет ориентацию стека - вертикальный или горизонтальный

                Spacing: устанавливает пространство между элементами в стеке, по молчанию равно 6 единицам
             * */

            Label labell1 = new Label()
            {
                Text = "Первая метка",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Red
            };
            Label labell2 = new Label()
            {
                Text = "Вторая метка",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Blue
            };
            Label labell3 = new Label()
            {
                Text = "Третья метка",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Green
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { labell1, labell2, labell3,stackLayoutXAML }
            };
            stackLayout.Spacing = 8;
            stackLayout.Orientation = StackOrientation.Vertical;



            //===============================================================================================





            //===========================================SCROLLVIEW=============================================
            StackLayout stLayScroll = new StackLayout();
            for (int i=1;i<35;i++)
            {
                Label lbl = new Label
                {
                    Text = "Метка " + i,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                };
                stLayScroll.Children.Add(lbl);
            }

            //==================================================================================================
            ScrollView scroll = new ScrollView();
            scroll.Content = stLayScroll;
            scroll.Margin = new Thickness(10);
            stackLayout.Children.Add(scroll);
            


            //==============================================AbsoluteLayout==========================================
            /*
             * AbsoluteLayout позволяет задавать вложенным элементам абсолютные 
             * координаты расположения на странице и подходит больше для тех случаев, 
             * когда нам нужны элементы с точными координатами.
             * 
             * 
             * */

            int x = 10; // позиция координаты X на странице
            int y = 10; // позиция координаты Y на странице
            int width = 100; // ширина блока элемента
            int height = 80;    // высота блока элемента
            Rectangle rect = new Rectangle(x, y, width, height);
            /*
             * Если нам неизвестна точная ширина и длина элемента, 
             * то мы можем ограничиться позиций , с которой начинается 
             * элемент, в виде структуры Point:
             * 
             * */

            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label
                {
                    Text = "Заголовок",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                },
            new Rectangle(70, 50, 150, 60)
                );
            absoluteLayout.Children.Add(
           new Label
           {
               Text = "Основное содержание текста",
               FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
           },
           new Point(30, 110)
       );
            stackLayout.Children.Add(absoluteLayout);
            this.Content = stackLayout;

            /*
             * Для установки позиции в качестве альтернативы мы можем использовать статический метод 
             * AbsoluteLayout.SetLayoutBounds(), который в качестве параметров принимает элемент и 
             * прямоугольную область, выделяемую для этого элемента:
             * 
             * AbsoluteLayout absoluteLayout = new AbsoluteLayout();
 
        Label headerLbl = new Label 
        { 
            Text = "Заголовок", 
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) 
        };
        Label contentLbl = new Label 
        { 
            Text = "Основное содержание текста", 
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) 
        };
 
        // определяем позицию и размеры для первой метки
        AbsoluteLayout.SetLayoutBounds(headerLbl, new Rectangle(70, 50, 150, 60));
        // определяем позицию и размеры для второй метки
        AbsoluteLayout.SetLayoutBounds(contentLbl, new Rectangle(30, 110, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        // добавление меток
        absoluteLayout.Children.Add(headerLbl);
        absoluteLayout.Children.Add(contentLbl);
 
        Content = absoluteLayout;
             * */
            //======================================================================================================


            //===========================================RelativeLayout=============================================
            /*
             * Контейнер RelativeLayout задает относительное позиционирование вложенных элементов 
             * относительно сторон контейнера или 
             * относительно других элементов.

                Позиционирование и размеры элементво внутри RelativeLayout определяются с 
                помощью ограничений. Ограничение представляет собой выражение, которое включает 
                следующую информацию:


             RelativeLayout relativeLayout = new RelativeLayout();
 
        BoxView redBox = new BoxView { BackgroundColor = Color.Red, WidthRequest=100, HeightRequest=100 };
        BoxView greenBox = new BoxView { BackgroundColor = Color.Green, WidthRequest=100, HeightRequest=100 };
        BoxView blueBox = new BoxView { BackgroundColor = Color.Blue };
 
        relativeLayout.Children.Add(redBox, Constraint.RelativeToParent((parent) =>
        {
            return 0;       // установка координаты X
        }));
 
        relativeLayout.Children.Add(greenBox,
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width / 3;    // установка координаты X
            }),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Height / 2;   // установка координаты Y
            })
        );
 
        relativeLayout.Children.Add(blueBox,
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width - 150;  // установка координаты X
            }),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Height - 100; // установка координаты Y
            }),
            Constraint.Constant(150), // установка ширины
            Constraint.Constant(100)  // установка высоты
        );
 
        Content = relativeLayout;
             * */
            //======================================================================================================

            //====================================================GRID==============================================
            /*
             *  Grid grid = new Grid
        {
            RowDefinitions = 
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
            },
            ColumnDefinitions = 
            {
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            }
        };
        grid.Children.Add(new BoxView { Color = Color.Red}, 0, 0);
        grid.Children.Add(new BoxView { Color = Color.Blue }, 0, 1);
        grid.Children.Add(new BoxView { Color = Color.Fuchsia }, 0, 2);
 
        grid.Children.Add(new BoxView { Color = Color.Teal}, 1, 0);
        grid.Children.Add(new BoxView { Color = Color.Green }, 1, 1);
        grid.Children.Add(new BoxView { Color = Color.Maroon }, 1, 2);
 
        grid.Children.Add(new BoxView { Color = Color.Olive }, 2, 0);
        grid.Children.Add(new BoxView { Color = Color.Pink }, 2, 1);
        grid.Children.Add(new BoxView { Color = Color.Yellow }, 2, 2);
 
        Content = grid;
             * */
            //======================================================================================================

        }


    }
}
