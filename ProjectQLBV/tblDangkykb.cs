using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQLBV
{
    class tblDangkykb
    {
        public string Madk { set; get; }
        public string hotendk { set; get; }
        public string thoigiandk { set; get; }
        public string thoigianhen { set; get; }
        public string buoihen { set; get; }
        public string sdtdk { set; get; }
        public string ghichudk { set; get; }
        public tblDangkykb(string ma = "", string ht = "", string tgdk = "", string tgh = "", string b = "", string sdt = "", string gc = "")
        {
            Madk = ma;
            hotendk = ht;
            thoigiandk = tgdk;
            thoigianhen = tgh;
            buoihen = b;
            sdtdk = sdt;
            ghichudk = gc;
        }
        public tblDangkykb(tblDangkykb apha)
        {
            Madk = apha.Madk;
            hotendk = apha.hotendk;
            thoigiandk = apha.thoigiandk;
            thoigianhen = apha.thoigianhen;
            buoihen = apha.buoihen;
            sdtdk = apha.sdtdk;
            ghichudk = apha.ghichudk;
        }
    }

}
