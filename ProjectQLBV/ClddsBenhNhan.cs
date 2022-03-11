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
    public partial class ClddsBenhNhan : Form
    {
        BenhnhanBLL bllBN;
        DataConnection dc;
        SqlDataAdapter da;
        List<tblBenhnhan> dsbenhnhan = new List<tblBenhnhan>();
        private static void Quick_Sort(List<tblBenhnhan> list, int left, int right)
        {
            //set the indexes
            int leftIndex = left;
            int rightIndex = right;

            //get the pivot
            var pivot = list[left + (right - left) / 2];
            while (leftIndex <= rightIndex)
            {
                //check left values
                while (string.Compare(list[leftIndex].hotenbn, pivot.hotenbn) < 0)
                {
                    leftIndex++;
                }
                //check right values
                while (string.Compare(list[rightIndex].hotenbn, pivot.hotenbn) > 0)
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
        private string Tostring(DataRow row, int i)
        {
            return row.ItemArray[i].ToString().Trim();
        }
        public ClddsBenhNhan()
        {
            InitializeComponent();
            bllBN = new BenhnhanBLL();
            DataTable dt = bllBN.getAllBenhnhan();
            foreach (DataRow row in dt.Rows)
            {
                tblBenhnhan apha = new tblBenhnhan();
                apha.MBN = Tostring(row, 0);
                apha.hotenbn = Tostring(row, 1);
                apha.ngaysinh = Tostring(row, 2);
                apha.gioitinh = Tostring(row, 3);
                apha.sdt = Tostring(row, 4);
                apha.diachi = Tostring(row, 5);
                apha.ghichu = Tostring(row, 6);
                apha.ngaykham = Tostring(row, 7);
                dsbenhnhan.Add(apha);
            }
        }
        List<tblBenhnhan> Sequencesearch(List<tblBenhnhan> list, string name)
        {
            List<tblBenhnhan> tmp = new List<tblBenhnhan>();
            foreach (var m in list)
            {
                if (m.hotenbn.ToLower().Contains(name.ToLower()) || m.MBN.ToLower().Contains(name.ToLower()))
                    tmp.Add(m);
            }
            return tmp;
        }
        public void ShowAllBenhnhan()
        {
            //DataTable dt = bllBN.getAllBenhnhan();
            //dgvBenhnhan.DataSource = dt;
            dgv_cldbenhnhan.DataSource = null;
            dgv_cldbenhnhan.DataSource = ConvertListOjbectToDataTable(dsbenhnhan);

        }
        private DataTable ConvertListOjbectToDataTable(List<tblBenhnhan> objectClass)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã bệnh nhân");
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Ghi chú");
            dt.Columns.Add("Ngày khám");
            foreach (tblBenhnhan bn in objectClass)
            {
                dt.Rows.Add(bn.MBN, bn.hotenbn, bn.ngaysinh, bn.gioitinh, bn.sdt, bn.diachi, bn.ghichu, bn.ngaykham);
            }
            return dt;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void search()
        {
            string value = txt_cldsearch.Text;
            if (!string.IsNullOrEmpty(value))
            {
                List<tblBenhnhan> ds = Sequencesearch(dsbenhnhan, value);
                dgv_cldbenhnhan.DataSource = null;
                dgv_cldbenhnhan.DataSource = ConvertListOjbectToDataTable(ds);
            }
            else
                ShowAllBenhnhan();
        }
        private void ClddsBenhNhan_Load(object sender, EventArgs e)
        {
            ShowAllBenhnhan();
            dgv_cldbenhnhan.BorderStyle = BorderStyle.None;
            dgv_cldbenhnhan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_cldbenhnhan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_cldbenhnhan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv_cldbenhnhan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_cldbenhnhan.BackgroundColor = Color.White;

            dgv_cldbenhnhan.EnableHeadersVisualStyles = false;
            dgv_cldbenhnhan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_cldbenhnhan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_cldbenhnhan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btn_cldsort_Click(object sender, EventArgs e)
        {
            Quick_Sort(dsbenhnhan, 0, dsbenhnhan.Count - 1);
            ShowAllBenhnhan();
        }

        private void txt_cldsearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void dgv_cldbenhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_cldmabn.Text = dgv_cldbenhnhan.Rows[index].Cells["Mã bệnh nhân"].Value.ToString();
                txt_cldtenbn.Text = dgv_cldbenhnhan.Rows[index].Cells["Họ tên"].Value.ToString();
                date_cldngsinh.Text = dgv_cldbenhnhan.Rows[index].Cells["Ngày sinh"].Value.ToString();
                txt_cldgioitinh.Text = dgv_cldbenhnhan.Rows[index].Cells["Giới tính"].Value.ToString();
                txt_cldsdt.Text = dgv_cldbenhnhan.Rows[index].Cells["Số điện thoại"].Value.ToString();
                txt_clddiachi.Text = dgv_cldbenhnhan.Rows[index].Cells["Địa chỉ"].Value.ToString();
                txt_cldghichu.Text = dgv_cldbenhnhan.Rows[index].Cells["Ghi chú"].Value.ToString();
                date_cldngkham.Text = dgv_cldbenhnhan.Rows[index].Cells["Ngày khám"].Value.ToString();

            }
        }

        private void txt_cldgioitinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
