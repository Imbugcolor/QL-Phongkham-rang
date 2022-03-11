using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQLBV
{
    public class ca
    {
        public List<tblBacsi> bacsi;
        public ca()
        {
            bacsi = new List<tblBacsi>();
        }
        public bool canadd()
        {
            return bacsi.Count < 2;
        }
        public tblBacsi bs()
        {
            if (bacsi.Count == 0)
            {
                return new tblBacsi();
            }
            else
            {
                return bacsi[0];
            }
        }
        public void add(tblBacsi apha)
        {
            bacsi.Add(apha);
        }
    }
    public class ngay
    {
        public ca[] ca = new ca[3];
        public ngay()
        {
            for(int i = 0; i < 3; i++)
            {
                ca[i] = new ca();
            }
        }
    }
    public class phong
    {
        public ngay[] ngay = new ngay[7];
        public phong()
        {
            for(int i = 0; i < 7; i++)
            {
                ngay[i] = new ngay();
            }
        }
    }
    public class tuan
    {
        public phong[] phong = new phong[2];
        public tuan()
        {
            for (int i = 0; i < 2; i++)
            {
                phong[i] = new phong();
            }
        }
    }
}
