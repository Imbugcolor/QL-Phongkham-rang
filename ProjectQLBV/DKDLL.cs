using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjectQLBV
{
    class DKDLL
    {
        DKDAL dalDK;
        public DKDLL()
        {
            dalDK = new DKDAL();
        }
        public DataTable getAllDK()
        {
            return dalDK.getAllDK();
        }
        public bool InsertDK(tblDangkykb dk)
        {
            return dalDK.InsertDK(dk);
        }
        public bool UpdateDK(tblDangkykb dk)
        {
            return dalDK.UpdateDK(dk);
        }
        public bool DeleteDK(tblDangkykb dk)
        {
            return dalDK.DeleteDK(dk);
        }
    }
}
