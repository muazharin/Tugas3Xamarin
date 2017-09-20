using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tugas3;
using System.IO;
using Tugas3.Droid;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using SQLite.Net;

[assembly: Dependency(typeof(SqliteService))]
namespace Tugas3.Droid
{
    public class SqliteService : InterfaceSQL
    {
        public SqliteService() { }
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Barang.db";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFilename);
            Console.WriteLine(path);
            if (!File.Exists(path)) { File.Create(path); }
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);
            return conn;
        }
    }
}