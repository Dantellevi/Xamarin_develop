using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.IO;
using projectSQLlite.iOS;


[assembly: Dependency(typeof(SQLite_iOS))]
namespace projectSQLlite.iOS
{
  public  class SQLite_iOS: ISQLite
    {
        public SQLite_iOS() { }
        public string GetDatabasePath(string filename)
        {
            // определяем путь к бд
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // папка библиотеки
            var path = Path.Combine(libraryPath, filename);

            return path;
        }
    }
}
