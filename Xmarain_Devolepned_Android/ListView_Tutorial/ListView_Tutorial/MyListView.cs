using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace ListView_Tutorial
{
    class MyListViewAdapter : BaseAdapter<Person>
    {

        public List<Person> mItems;     //список для ListView
        private Context mContext;       

        public MyListViewAdapter(Context _cont,List<Person> items)
        {
            mItems = items;
            mContext = _cont;

        }

        /*
         * 
         * Индексаторы позволяют индексировать объекты и использовать их как массивы. 
         * Фактически индексаторы позволяют нам создавать специальные хранилища объектов или коллекции. 
         * По форме они напоминают свойства со стандартными методами get и set, которые возвращают и 
         * присваивают значение.
         * */

            /// <summary>
            /// Индексатор который возращает определенный элемент списка
            /// </summary>
            /// <param name="position">индекс списка</param>
            /// <returns></returns>
        public override Person this[int position]
        {
            get
            {
                
               return mItems[position];
               
            }
        }

       

        /// <summary>
        /// Свойство , которое возращает кол-во элементов
        /// </summary>
        public override int Count
        {
            get
            {
              return  mItems.Count();
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }


        /// <summary>
        /// Метод определяющий вывод информации в соответствующее представление
        /// </summary>
        /// <param name="position"></param>
        /// <param name="convertView"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if(row==null)
            {
                //============================Работаем с представлением ListView_row=========================
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListView_row,null,false);


            }


            //===========================присваевание полям в представлении значений из списка данных=======================
            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            txtName.Text = mItems[position].FirstName;

            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.txtName);
            txtLastName.Text = mItems[position].LastName;

            TextView txtAge = row.FindViewById<TextView>(Resource.Id.txtAge);
            txtAge.Text = mItems[position].Age;

            TextView txtGender = row.FindViewById<TextView>(Resource.Id.txtGender);
            txtGender.Text = mItems[position].Gender;
            //===============================================================================================================



            return row;
        }
    }
}