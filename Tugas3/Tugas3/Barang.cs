using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;

namespace Tugas3
{
    public class Barang
    {
        [PrimaryKey, AutoIncrement]
        public long BarId { get; set; }
        [NotNull]
        public string TransBar { get; set; }
        public string Tanggal { get; set; }
        public string HrgBar { get; set; }
        public string InfoBar { get; set; }

    }
}
