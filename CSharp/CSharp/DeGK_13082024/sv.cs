using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeGK_13082024
{
    public class sinhvien
    {
        public string ID;
        public string Name;
        public DateTime Birthday;
        public sinhvien(string id, string name, DateTime bir)
        {
            ID = id;
            Name = name;
            Birthday = bir;
        }
    }
}
