using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQLBV
{
    public class tblBacsi
    {
        public string MS { set; get; }
        public string hotenbs { set; get; }
        public string Ngaysinh { set; get; }
        public string Gioitinh { set; get; }
        public string sdt { set; get; }
        public string diachi { set; get; }
        public int ngayDalam { set; get; }
        public tblBacsi()
        {
        }
        public tblBacsi(tblBacsi apha)
        {
            MS = apha.MS;
            hotenbs = apha.hotenbs;
            Ngaysinh = apha.Ngaysinh;
            Gioitinh = apha.Gioitinh;
            sdt = apha.sdt;
            diachi = apha.diachi;
            ngayDalam = apha.ngayDalam;
        }
       
    }
}
