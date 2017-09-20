using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;

namespace Tugas3
{
    public interface InterfaceSQL
    {
        SQLiteConnection GetConnection();
    }
}
