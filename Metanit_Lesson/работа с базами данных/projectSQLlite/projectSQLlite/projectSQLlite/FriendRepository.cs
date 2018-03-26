using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace projectSQLlite
{
  
   public class FriendRepository
    {
        SQLiteConnection database;
        static object locker = new object();        //переменная для блокировки при одновременном доступе из нескольких потоков
        public FriendRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Friend>();

           

        }

        public IEnumerable<Friend> GetItems()
        {
            //преобразуем данные из БД в список и возращаем их
            return (from i in database.Table<Friend>() select i).ToList();  //возвращает все объекты из таблицы
        }

        /// <summary>
        /// Метод возращает конкретные данные по идентификатору
        /// </summary>
        /// <param name="id">Индетификатор для поиска</param>
        /// <returns></returns>
        public Friend GetItem(int id)
        {
            return database.Get<Friend>(id);    //позволяет получить элемент типа T по id
        }
        public int DeleteItem(int id)
        {
            lock(locker)
            {
                return database.Delete<Friend>(id); //удаляет объект по id
            }
           
        }


        /// <summary>
        /// Сохранения данных в БД
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int SaveItem(Friend item)
        {
            if(item.Id!=0)
            {
                database.Update(item); //обновляет объект
                return item.Id;
            }
            else
            {
                return database.Insert(item);   // добавляет объект в таблицу
            }
        }



    }
}
