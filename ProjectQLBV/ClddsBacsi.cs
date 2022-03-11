using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLBV
{
    public partial class ClddsBacsi : Form
    {
        BacsiBLL bllBS2;
        DataConnection dc2;
        SqlDataAdapter da2;
        List<tblBacsi> dsbacsi2 = new List<tblBacsi>();
        private static void Quick_Sort(List<tblBacsi> list, int left, int right)
        {
            //set the indexes
            int leftIndex = left;
            int rightIndex = right;

            //get the pivot
            var pivot = list[left + (right - left) / 2];
            while (leftIndex <= rightIndex)
            {
                //check left values
                while (string.Compare(list[leftIndex].hotenbs, pivot.hotenbs) < 0)
                {
                    leftIndex++;
                }
                //check right values
                while (string.Compare(list[rightIndex].hotenbs, pivot.hotenbs) > 0)
                {
                    rightIndex--;
                }
                //swap
                if (leftIndex <= rightIndex)
                {
                    var tmp = list[leftIndex];
                    list[leftIndex] = list[rightIndex];
                    list[rightIndex] = tmp;

                    //move towards pivot
                    leftIndex++;
                    rightIndex--;
                }
            }
            //continues to sort left and right of pivot
            if (left < rightIndex)
            {
                Quick_Sort(list, left, rightIndex);
            }
            if (leftIndex < right)
            {
                Quick_Sort(list, leftIndex, right);
            }
        }
        private int Toint(DataRow row, int i)
        {
            return int.Parse(row.ItemArray[i].ToString());
        }
        private string Tostring(DataRow row, int i)
        {
            return row.ItemArray[i].ToString().Trim();
        }
        //TIMKIEMTUANTU////////////////////////////////////////////////////////////TIMKIEMTUANTU
        List<tblBacsi> Sequencesearch(List<tblBacsi> list, string infor)
        {
            List<tblBacsi> tmp = new List<tblBacsi>();
            foreach (var m in list)
            {
                if (m.hotenbs.ToLower().Contains(infor.ToLower()) || m.MS.ToLower().Contains(infor.ToLower()))
                    tmp.Add(m);
            }
            return tmp;
        }
        public ClddsBacsi()
        {
            InitializeComponent();
            bllBS2 = new BacsiBLL();
            DataTable dt = bllBS2.getAllBacsi();
            foreach (DataRow row in dt.Rows)
            {
                tblBacsi apha = new tblBacsi();
                apha.MS = Tostring(row, 0);
                apha.hotenbs = Tostring(row, 1);
                apha.Ngaysinh = Tostring(row, 2);
                apha.Gioitinh = Tostring(row, 3);
                apha.sdt = Tostring(row, 4);
                apha.diachi = Tostring(row, 5);
                dsbacsi2.Add(apha);
            }

        }
        private DataTable ConvertListOjbectToDataTable(List<tblBacsi> objectClass)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Bác Sĩ");
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            foreach (tblBacsi bs in objectClass)
            {
                dt.Rows.Add(bs.MS, bs.hotenbs, bs.Ngaysinh, bs.Gioitinh, bs.diachi, bs.sdt);
            }
            return dt;
        }
        public void ShowAllBacsi()
        {
            //DataTable dt = bllBS.getAllBacsi();
            //dgvBacsi.DataSource = dt;
            dgv_cldbacsi.DataSource = null;
            dgv_cldbacsi.DataSource = ConvertListOjbectToDataTable(dsbacsi2);
        }


        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgv_cldbacsi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //MBS = dgvBacsi.Rows[index].Cells["MS"].Value.ToString();
                txt_cldmabs.Text = dgv_cldbacsi.Rows[index].Cells["Mã Bác Sĩ"].Value.ToString();
                txt_cldtenbs.Text = dgv_cldbacsi.Rows[index].Cells["Họ và tên"].Value.ToString();
                date_cldngsinh.Text = dgv_cldbacsi.Rows[index].Cells["Ngày sinh"].Value.ToString();
                txt_cldgioitinh.Text = dgv_cldbacsi.Rows[index].Cells["Giới tính"].Value.ToString();
                txt_cldsdt.Text = dgv_cldbacsi.Rows[index].Cells["Số điện thoại"].Value.ToString();
                txt_clddiachi.Text = dgv_cldbacsi.Rows[index].Cells["Địa chỉ"].Value.ToString();
            }
        }

        private void btn_cldsort_Click(object sender, EventArgs e)
        {
            Quick_Sort(dsbacsi2, 0, dsbacsi2.Count - 1);
            //ShowAllBacsi();
            dgv_cldbacsi.DataSource = null;
            dgv_cldbacsi.DataSource = ConvertListOjbectToDataTable(dsbacsi2);
        }

        private void txt_cldsearch_TextChanged(object sender, EventArgs e)
        {
            string value = txt_cldsearch.Text;     

            if (!string.IsNullOrEmpty(value))
            {
                List<tblBacsi> ds = Sequencesearch(dsbacsi2, value);
                dgv_cldbacsi.DataSource = null;
                dgv_cldbacsi.DataSource = ConvertListOjbectToDataTable(ds);
            }
            else
            {
                ShowAllBacsi();
            }
        }
        private void ClddsBacsi_Load(object sender, EventArgs e)
        {
            ShowAllBacsi();
            dgv_cldbacsi.BorderStyle = BorderStyle.None;
            dgv_cldbacsi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_cldbacsi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_cldbacsi.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv_cldbacsi.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_cldbacsi.BackgroundColor = Color.White;

            dgv_cldbacsi.EnableHeadersVisualStyles = false;
            dgv_cldbacsi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_cldbacsi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_cldbacsi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
