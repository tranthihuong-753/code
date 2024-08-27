using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace De1_06082024
{
    internal class Sim
    {
        public string simID;
        public string soSim;
        public DateTime ngayKichHoat;
        public DateTime ngayHetHan; // new DateTime(2024, 12, 31)
        public string ghiChu;

        public Sim() { }
        public Sim(string simid, string sosim, DateTime ngaykichhoat, DateTime ngayhethan, string ghichu)
        {
            simID = simid;
            soSim = sosim;
            ngayKichHoat = ngaykichhoat;
            ngayHetHan = ngayhethan;
            ghiChu = ghichu;
        }
        
    }
}
