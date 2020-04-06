using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SqlEx
{
   public interface ISqliteConnection
    {
        SQLiteConnection GetConnection();
    }
}
