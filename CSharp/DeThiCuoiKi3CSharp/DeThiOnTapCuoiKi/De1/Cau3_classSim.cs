using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Khai báo 1 class Sim gồm các biến public: simID, soSim, ngayKichHoat, ngayHetHan 
// và ghiChu với kiểu dữ liệu phù hợp trong 1 file .cs riêng. 

namespace De1
{
    class Sim
    {
        public string simID;
        public string soSim;
        public DateTime ngayKichHoat;
        public DateTime ngayHetHan;
        public string ghiChu;
        public Sim(string simID, string soSim, DateTime ngayKichHoat, DateTime ngayHetHan, string ghiChu)
        {
            this.simID = simID;
            this.soSim = soSim;
            this.ngayKichHoat = ngayKichHoat;
            this.ngayHetHan = ngayHetHan;
            this.ghiChu = ghiChu;
        }
    }
}
