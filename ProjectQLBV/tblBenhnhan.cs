using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQLBV
{
    class tblBenhnhan
    {
        public string MBN { set; get; }
        public string hotenbn { set; get; }
        public string ngaysinh { set; get; }
        public string gioitinh { set; get; }
        public string sdt { set; get; }
        public string diachi { set; get; }
        public string ghichu { set; get; }
        public string ngaykham { set; get; }
        public tblBenhnhan()
        {
        }
        public tblBenhnhan(tblBenhnhan apha)
        {
            MBN = apha.MBN;
            hotenbn = apha.hotenbn;
            ngaysinh = apha.ngaysinh;
            gioitinh = apha.gioitinh;
            sdt = apha.sdt;
            diachi = apha.diachi;
            ghichu = apha.ghichu;
            ngaykham = apha.ngaykham;
        }
    }
}
