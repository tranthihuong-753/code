using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De7
{
    internal class Cau1
    {
        static void Main(string[] args)
        {
            string createtable = "create table CongDan(\r\n\tMaCD varchar(9) primary key,\r\n\tTenCD nvarchar(200),\r\n\tCCCD varchar(12),\r\n\tGioiTinh varchar(50) check (GioiTinh in('Nam', 'Nu', 'Khong xac dinh')),\r\n\tNgaySinh Datetime\r\n)";
        }
    }
}
