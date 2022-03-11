using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjectQLBV
{
    class BacsiBLL
    {
        BacsiDAL dalBS;
        public BacsiBLL()
        {
            dalBS = new BacsiDAL();
        }
        public DataTable getAllBacsi()
        {
            return dalBS.getAllBacsi();
        }
        public bool InsertBacsi(tblBacsi bs)
        {
            return dalBS.InsertBacsi(bs);
        }
        public bool UpdateBacsi(tblBacsi bs)
        {
            return dalBS.UpdateBacsi(bs);
        }
        public bool DeleteBacsi(tblBacsi bs)
        {
            return dalBS.DeleteBacsi(bs);
        }
        public DataTable SearchBS(string bs)
        {
            return dalBS.SearchBS(bs);
        }
    }
}
