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

        public List<Person> mItems;     //������ ��� ListView
        private Context mContext;       

        public MyListViewAdapter(Context _cont,List<Person> items)
        {
            mItems = items;
            mContext = _cont;

        }

        /*
         * 
         * ����������� ��������� ������������� ������� � ������������ �� ��� �������. 
         * ���������� ����������� ��������� ��� ��������� ����������� ��������� �������� ��� ���������. 
         * �� ����� ��� ���������� �������� �� ������������ �������� get � set, ������� ���������� � 
         * ����������� ��������.
         * */

            /// <summary>
            /// ���������� ������� ��������� ������������ ������� ������
            /// </summary>
            /// <param name="position">������ ������</param>
            /// <returns></returns>
        public override Person this[int position]
        {
            get
            {
                
               return mItems[position];
               
            }
        }

       

        /// <summary>
        /// �������� , ������� ��������� ���-�� ���������
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
        /// ����� ������������ ����� ���������� � ��������������� �������������
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
                //============================�������� � �������������� ListView_row=========================
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListView_row,null,false);


            }


            //===========================������������ ����� � ������������� �������� �� ������ ������=======================
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