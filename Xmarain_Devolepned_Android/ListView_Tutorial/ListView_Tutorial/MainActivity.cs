using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ListView_Tutorial
{
    [Activity(Label = "ListView_Tutorial", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //int count = 1;
        private List<Person> mItems;
        private ListView mListView;     //создаем внешний ListView

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mListView = FindViewById<ListView>(Resource.Id.MyListView); //находим объект по индификатору типа

            //================================Создаем список текущей модели==============================
            mItems = new List<Person>();
            mItems.Add(new Person {FirstName="Саня",LastName="Лепотенко",Age="24",Gender="Мужской" });
            mItems.Add(new Person { FirstName = "Саня", LastName = "Лепотенко", Age = "24", Gender = "Мужской" });
            mItems.Add(new Person { FirstName = "Павел", LastName = "Лепотенко", Age = "14", Gender = "Мужской" });
            mItems.Add(new Person { FirstName = "Виктор", LastName = "Рак", Age = "22", Gender = "Мужской" });
            mItems.Add(new Person { FirstName = "Витек", LastName = "Яцинович", Age = "24", Gender = "Мужской" });
            mItems.Add(new Person { FirstName = "Алексей", LastName = "Мигуро", Age = "24", Gender = "Мужской" });

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);//устанавливаем связь со списков в представлении и загрузаем в список который в представлении данные
            
            //mItems = new List<string>();    //создаем непосредственный список для загрузки
            //mItems.Add("Саня");
            //mItems.Add("Витек");
            //mItems.Add("Алексей");

            //ArrayAdapter adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems); //устанавливаем связь со списков в представлении и загрузаем в список который в представлении данные
            // MyListViewAdapter adapter = new MyListViewAdapter(this,mItems);//устанавливаем связь со списков в представлении и загрузаем в список который в представлении данные
            //string indexerTest = adapter.mItems[1];

            mListView.Adapter = adapter;        //указываем объект который отвечает за связь между представлением и кодом 


            //=======================================Событие нажатия на экран======================

            mListView.ItemClick += MListView_ItemClick;
            mListView.ItemLongClick += MListView_ItemLongClick;
            //====================================================================================

            // SetContentView (Resource.Layout.Main);
        }

        private void MListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Console.WriteLine(mItems[e.Position].LastName);
        }

        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(mItems[e.Position].FirstName);

        }
    }
}

