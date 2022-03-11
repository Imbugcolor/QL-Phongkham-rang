using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLBV
{
    public partial class WorkCalender : Form
    {
        DateTime defaulttime = Convert.ToDateTime("31/1/2022");
        int count_tuan;
        List<tuan> ds_tuan = new List<tuan>();
        List<tblBacsi> dsBacsi = new List<tblBacsi>();
        System.Windows.Forms.Button[,] listbtn = new System.Windows.Forms.Button[6, 7];
        int phg_Showed = 0;
        private int Toint(DataRow row, int i)
        {
            return int.Parse(row.ItemArray[i].ToString());
        }
        int time(DateTime apha)
        {
            TimeSpan temp = apha - defaulttime;
            return temp.Days / 7;
        }
        private string Tostring(DataRow row, int i)
        {
            return row.ItemArray[i].ToString().Trim();
        }
        void BStoPhong(tblBacsi B, phong P)
        {
            int temp = 0;                   //O(1)                                                                
            int dem = 0;                    //O(1)
            for (int c = 0; c < 3; c++)     //O(3)
            {//theo ca                      
                tblBacsi apha = null;       //O(1)
                int beta = 0;               //O(1)
                for (int t = 0; t < 7; t++) //O(7)
                {//theo ngay
                    if (beta == 1)          //O(1)
                    {
                        t++;                //O(1)
                        beta = 0;           //O(1)
                        apha = null;        //O(1)
                        if (t >= 7)         //O(1)
                        {
                            break;          //O(1)
                        }
                    }
                    if (P.ngay[t].ca[c].canadd())   //O(1)
                    {
                        if (apha == null)   //O(1)
                        {
                            apha = P.ngay[t].ca[c].bs();    //O(1)
                        }
                        else if (apha == P.ngay[t].ca[c].bs()) //O(1)

                        {
                            beta++;                 //O(1)
                        }
                        else                        //O(1)
                        {
                            apha = P.ngay[t].ca[c].bs();  //O(1)
                        }
                        P.ngay[t].ca[c].add(B);     //O(1)
                        B.ngayDalam++;              //O(1)
                        temp++;                     //O(1)
                        dem++;                      //O(1)
                    }
                    if (temp == 5)                  //O(1)
                    {
                        temp = 0;                   //O(1)
                        break;                      //O(1)
                    }
                    if (dem == 8)                   //O(1)
                    {
                        return;                     //O(1)
                    }
                }
            }
        }
        bool Canadd(int i)
        {
            for (int c = 0; c < 3; c++)             //O(3)
            {
                for (int t = 0; t < 7; t++)         //O(7)
                {
                    for(int p = 0; p < 2; p++)      //O(N)
                    {
                        if (ds_tuan[i].phong[p].ngay[t].ca[c].canadd())    //O(1)
                        {
                            return true;            //O(1)
                        }
                    }
                }
            }
            return false;                       //O(1)
        }
        void listTophong()
        {
            int phg = 0;                       //O(1)
            for (int i = 0; i < 20; i++)       //V
            {
                while (Canadd(i))              //O(N)
                {
                    BStoPhong(dsBacsi[0], ds_tuan[i].phong[phg]);   //O(1)
                    phg = phg == 0 ? 1 : 0;     //O(1)
                    dsBacsi.Sort(               //O(1)
                        delegate (tblBacsi a, tblBacsi b)       //O(1)
                        {
                            return a.ngayDalam.CompareTo(b.ngayDalam);  //O(1)
                        }
                    );
                }
            }
        }
        tblBacsi show_bs(int ngay, int ca, int i)
        {
            ca apha = ds_tuan[count_tuan].phong[phg_Showed].ngay[ngay].ca[ca];
            if(apha.bacsi.Count <= i)
            {
                return new tblBacsi();
            }
            else
            {
                return apha.bacsi[i];
            }
        }
        string bsTobtn(tblBacsi apha)
        {
            string omega = apha.MS + "\n" + apha.hotenbs;
            return omega;
        }
        void show_btn()
        {
            set_thu();
            for (int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    listbtn[j, i].Text = "";
                }
            }
            for (int i = 0; i < 7; i++)
            {
                listbtn[0, i].Text = bsTobtn(show_bs(i, 0, 0));
                listbtn[1, i].Text = bsTobtn(show_bs(i, 0, 1));
                listbtn[2, i].Text = bsTobtn(show_bs(i, 1, 0));
                listbtn[3, i].Text = bsTobtn(show_bs(i, 1, 1));
                listbtn[4, i].Text = bsTobtn(show_bs(i, 2, 0));
                listbtn[5, i].Text = bsTobtn(show_bs(i, 2, 1));
            }
        }
        string ngay_thang_nam(int i)
        {
            DateTime apha = defaulttime.AddDays(count_tuan * 7 + i);
            return apha.Date.ToString() + "/" + apha.Month.ToString() + "/" + apha.Year.ToString();
        }
        void set_thu()
        {
            btn_t2.Text = "thứ 2 \n" + ngay_thang_nam(0);
            btn_t3.Text = "thứ 3 \n" + ngay_thang_nam(1);
            btn_t4.Text = "thứ 4 \n" + ngay_thang_nam(2);
            btn_t5.Text = "thứ 5 \n" + ngay_thang_nam(3);
            btn_t6.Text = "thứ 6 \n" + ngay_thang_nam(4);
            btn_t7.Text = "thứ 7 \n" + ngay_thang_nam(5);
            btn_cn.Text = "chủ nhật \n" + ngay_thang_nam(6);
        }
        public WorkCalender()
        {
            InitializeComponent();
            count_tuan = time(DateTime.Now);
            {
                listbtn[0, 0] = this.btn_st2_1;
                listbtn[0, 1] = this.btn_st3_1;
                listbtn[0, 2] = this.btn_st4_1;
                listbtn[0, 3] = this.btn_st5_1;
                listbtn[0, 4] = this.btn_st6_1;
                listbtn[0, 5] = this.btn_st7_1;
                listbtn[0, 6] = this.btn_scn_1;

                listbtn[1, 0] = this.btn_st2_2;
                listbtn[1, 1] = this.btn_st3_2;
                listbtn[1, 2] = this.btn_st4_2;
                listbtn[1, 3] = this.btn_st5_2;
                listbtn[1, 4] = this.btn_st6_2;
                listbtn[1, 5] = this.btn_st7_2;
                listbtn[1, 6] = this.btn_scn_2;

                listbtn[2, 0] = this.btn_tt2_1;
                listbtn[2, 1] = this.btn_tt3_1;
                listbtn[2, 2] = this.btn_tt4_1;
                listbtn[2, 3] = this.btn_tt5_1;
                listbtn[2, 4] = this.btn_tt6_1;
                listbtn[2, 5] = this.btn_tt7_1;
                listbtn[2, 6] = this.btn_tcn_1;

                listbtn[3, 0] = this.btn_tt2_2;
                listbtn[3, 1] = this.btn_tt3_2;
                listbtn[3, 2] = this.btn_tt4_2;
                listbtn[3, 3] = this.btn_tt5_2;
                listbtn[3, 4] = this.btn_tt6_2;
                listbtn[3, 5] = this.btn_tt7_2;
                listbtn[3, 6] = this.btn_tcn_2;

                listbtn[4, 0] = this.btn_ct2_1;
                listbtn[4, 1] = this.btn_ct3_1;
                listbtn[4, 2] = this.btn_ct4_1;
                listbtn[4, 3] = this.btn_ct5_1;
                listbtn[4, 4] = this.btn_ct6_1;
                listbtn[4, 5] = this.btn_ct7_1;
                listbtn[4, 6] = this.btn_ccn_1;

                listbtn[5, 0] = this.btn_ct2_2;
                listbtn[5, 1] = this.btn_ct3_2;
                listbtn[5, 2] = this.btn_ct4_2;
                listbtn[5, 3] = this.btn_ct5_2;
                listbtn[5, 4] = this.btn_ct6_2;
                listbtn[5, 5] = this.btn_ct7_2;
                listbtn[5, 6] = this.btn_ccn_2;
            }
            for (int i = 0; i < 20; i++)
            {
                ds_tuan.Add(new tuan());
            }
            BacsiBLL bllBS;
            bllBS = new BacsiBLL();
            DataTable dt = bllBS.getAllBacsi();
            foreach (DataRow row in dt.Rows)
            {
                tblBacsi apha = new tblBacsi();
                apha.MS = Tostring(row, 0);
                apha.hotenbs = Tostring(row, 1);
                apha.Ngaysinh = Tostring(row, 2);
                apha.Gioitinh = Tostring(row, 3);
                apha.sdt = Tostring(row, 4);
                apha.diachi = Tostring(row, 5);
                apha.ngayDalam = 0;
                dsBacsi.Add(apha);
                dsBacsi.Sort(
                    delegate (tblBacsi a, tblBacsi b)
                    {
                        return a.ngayDalam.CompareTo(b.ngayDalam);
                    }
                );
            }
            listTophong();
            show_btn();
        }
        private void button50_Click(object sender, EventArgs e)
        {
            if(!(phg_Showed == 0))
            {
                phg_Showed = 0;
                show_btn();
            }
        }
        private void button51_Click(object sender, EventArgs e)
        {
            if (!(phg_Showed == 1))
            {
                phg_Showed = 1;
                show_btn();
            }
        }
        private void prevbtn_Click(object sender, EventArgs e)
        {
            DateCurrent.Value = DateCurrent.Value.AddDays(-7);
        }
        private void nxtbtn_Click(object sender, EventArgs e)
        {
            DateCurrent.Value = DateCurrent.Value.AddDays(+7);
        }
        private void DateCurrent_ValueChanged(object sender, EventArgs e)
        {
            int temp = time(DateCurrent.Value);
            if (temp >= 0 && temp < 20)
            {
                count_tuan = temp;
            }
            else
            {
                MessageBox.Show("đã xảy ra lỗi");
                DateCurrent.Value = defaulttime.AddDays(count_tuan * 7);
            }
            show_btn();
        }
    }
}
