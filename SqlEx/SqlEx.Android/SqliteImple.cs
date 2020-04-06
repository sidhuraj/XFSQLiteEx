using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SqlEx.Droid;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(SqliteImple))]
namespace SqlEx.Droid
{
    public class SqliteImple : ISqliteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Emplyee.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
           var  sqlitConnection = new SQLiteConnection(path);
            return sqlitConnection;

        }
    }
}