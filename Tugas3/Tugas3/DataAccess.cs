using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;
using Xamarin.Forms;

namespace Tugas3
{
    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            //ini untuk membuat koneksi ke database melalui interface
            dbConn = DependencyService.Get<InterfaceSQL>().GetConnection();
            //ini untuk membuat table secara otomatis
            dbConn.CreateTable<Barang>();
        }
        //ini method untuk menampilkan semua barang yang diinputkan
        public List<Barang> GetAllBarang()
        {
            return dbConn.Query<Barang>("Select * From [Barang]");
        }
        //ini untuk menyimpan data barang yang ditambahkan
        public int SaveBarang(Barang aBarang)
        {
            return dbConn.Insert(aBarang);
        }
        //ini untuk menghapus daftar barang yang dipilih
        public int DeleteBarang(Barang aBarang)
        {
            return dbConn.Delete(aBarang);
        }
        //ini untuk mengedit data dari barang yang dimasukkan
        public int EditBarang(Barang aBarang)
        {
            return dbConn.Update(aBarang);
        }
    }
}
