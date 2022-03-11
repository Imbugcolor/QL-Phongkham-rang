using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjectQLBV
{
    class BenhnhanBLL
    {
        BenhnhanDAL dalBN;
        public BenhnhanBLL()
        {
            dalBN = new BenhnhanDAL();
        }
        public DataTable getAllBenhnhan()
        {
            return dalBN.getAllBenhnhan();
        }
        public bool InsertBenhnhan(tblBenhnhan bn)
        {
            return dalBN.InsertBenhnhan(bn);
        }
        public bool UpdateBenhnhan(tblBenhnhan bn)
        {
            return dalBN.UpdateBenhnhan(bn);
        }
        public bool DeleteBenhnhan(tblBenhnhan bn)
        {
            return dalBN.DeleteBenhnhan(bn);
        }
        public DataTable SearchBenhnhan(string bn)
        {
            return dalBN.SearchBN(bn);
        }
    }
}
