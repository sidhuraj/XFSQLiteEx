using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SqlEx
{
   public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int EmpId { set; get; }
        public string EmpName { set; get; }
        public string EmpAddress { set; get; }
    }
}
