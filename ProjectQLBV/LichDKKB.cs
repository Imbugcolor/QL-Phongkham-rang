using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLBV
{
    public partial class LichDKKB : Form
    {
        //stt Mã đăng kí  Họ Và Tên Ghi chú sđt
        DKDLL bllBN;
        private string Tostring(DataRow row, int i)
        {
            return row.ItemArray[i].ToString().Trim();
        }
        //year-month-day hh:tt
        DateTime converstringtoDatetime(string s)
        {
            try
            {
                string[] base0 = s.Split(' ');
                string[] day = base0[0].Split('-');
                string[] hour = base0[1].Split(':');
                DateTime apha = new DateTime(int.Parse(day[0]), int.Parse(day[1]), int.Parse(day[2]), int.Parse(hour[0]), int.Parse(hour[1]), 0);
                return apha;
            }
            catch
            {
                string[] temp = s.Split('-');
                DateTime apha = new DateTime(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));
                return apha;
            }
        }
        bool cmp(DateTime apha, DateTime beta)
        {
            return apha.Day == beta.Day && apha.Month == beta.Month && apha.Year == beta.Year;
        }
        void setupData(int penta) // ham chinh
        {
            data_show.DataSource = null; //O(1)
            bllBN = new DKDLL(); //O(1)
            DataTable dt = bllBN.getAllDK(); //O(1)
            List<tblDangkykb> temp = new List<tblDangkykb>(); // hang doi //O(1)
            foreach(DataRow row in dt.Rows) //O(n)
            {
                if ((penta == 0 && Tostring(row, 4) == "Sáng") || 
                    (penta == 1 && Tostring(row, 4) == "Chiều") ||  
                    (penta == 2 && Tostring(row, 4) == "Tối"))   //O(1)
                {
                    if (cmp(converstringtoDatetime(Tostring(row, 3)), date_henkham.Value))
                    {
                        temp.Add(new tblDangkykb(Tostring(row, 0), Tostring(row, 1), Tostring(row, 2), 
                            Tostring(row, 3), Tostring(row, 4), Tostring(row, 5), Tostring(row, 6)));
                    } //O(1)
                }
                int n = temp.Count - 1; //O(1)
                while (n > 0) // uu tien   //O(n)
                {
                    if (converstringtoDatetime(temp[n].thoigiandk) 
                        < converstringtoDatetime(temp[n - 1].thoigiandk)) //O(1)
                    {
                        tblDangkykb p = new tblDangkykb(temp[n]);
                        temp[n] = new tblDangkykb(temp[n - 1]);     //O(1)
                        temp[n - 1] = new tblDangkykb(p); 
                        n--;
                    }
                    else
                    {
                        break;     //O(1)
                    }
                }
            }
            DataTable table = new DataTable();
            table.Columns.Add("stt");
            table.Columns.Add("Mã đăng kí");
            table.Columns.Add("Họ Và Tên");
            table.Columns.Add("Ghi chú");
            table.Columns.Add("sđt");
            int i = 1;
            foreach(tblDangkykb row in temp)
            {
                table.Rows.Add(i, row.Madk, row.hotendk, row.ghichudk, row.sdtdk);
                i++;
            }
            data_show.DataSource = table;
        }
        public LichDKKB()
        {
            InitializeComponent();
            cbb_buoihen.SelectedIndex = 0;
            DateTime temp = DateTime.Now;
            date_henkham.Value = new DateTime(temp.Year,temp.Month,temp.Day);
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            date_henkham.Value = date_henkham.Value.AddDays(-1);
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            date_henkham.Value = date_henkham.Value.AddDays(1);
        }
        private void date_henkham_ValueChanged(object sender, EventArgs e)
        {
            setupData(cbb_buoihen.SelectedIndex);
        }
        private void cbb_buoihen_SelectedIndexChanged(object sender, EventArgs e)
        {
            setupData(cbb_buoihen.SelectedIndex);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
