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
    public partial class TableBN : Form
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
        public TableBN()
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
            dgvBenhnhan.DataSource = null;
            dgvBenhnhan.DataSource = ConvertListOjbectToDataTable(dsbenhnhan);

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
                dt.Rows.Add(bn.MBN, bn.hotenbn, bn.ngaysinh, bn.gioitinh, bn.sdt, bn.diachi,bn.ghichu,bn.ngaykham);
            }
            return dt;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public bool CheckData2()
        {
            if (string.IsNullOrEmpty(txtMBN.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã bệnh nhân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMBN.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txthotenbn.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên bệnh nhân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthotenbn.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(date_ngaysinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_ngaysinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtgioitinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgioitinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsdt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtdiachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtghichu.Text))
            {
                MessageBox.Show("Bạn chưa nhập ghi chú.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtghichu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(date_ngaykham.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày khám.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_ngaykham.Focus();
                return false;
            }
            return true;
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (CheckData2())
            {
                tblBenhnhan bn = new tblBenhnhan();
                bn.MBN = txtMBN.Text;
                bn.hotenbn = txthotenbn.Text;
                bn.ngaysinh = date_ngaysinh.Value.Year + "-" + date_ngaysinh.Value.Month + "-" + date_ngaysinh.Value.Day;
                bn.gioitinh = txtgioitinh.Text;
                bn.sdt = txtsdt.Text;
                bn.diachi = txtdiachi.Text;
                bn.ghichu = txtghichu.Text;
                bn.ngaykham = date_ngaykham.Value.Year + "-" + date_ngaykham.Value.Month + "-" + date_ngaykham.Value.Day;
                if (bllBN.InsertBenhnhan(bn))
                {
                    dsbenhnhan.Clear();
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
                    ShowAllBenhnhan();
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }

        private void TableBN_Load(object sender, EventArgs e)
        {
            ShowAllBenhnhan();
        }
        private void dgvBenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void repairbtn_Click(object sender, EventArgs e)
        {
            if (CheckData2())
            {
                tblBenhnhan bn = new tblBenhnhan();
                bn.MBN = txtMBN.Text;
                bn.hotenbn = txthotenbn.Text;
                bn.ngaysinh = date_ngaysinh.Value.Year + "-" + date_ngaysinh.Value.Month + "-" + date_ngaysinh.Value.Day;
                bn.gioitinh = txtgioitinh.Text;
                bn.sdt = txtsdt.Text;
                bn.diachi = txtdiachi.Text;
                bn.ghichu = txtghichu.Text;
                bn.ngaykham = date_ngaykham.Value.Year + "-" + date_ngaykham.Value.Month + "-" + date_ngaykham.Value.Day;
                if (bllBN.UpdateBenhnhan(bn))
                {
                    dsbenhnhan.Clear();
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
                    ShowAllBenhnhan();
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
        private void removebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                tblBenhnhan bn = new tblBenhnhan();
                bn.MBN = txtMBN.Text;
                if (bllBN.DeleteBenhnhan(bn))
                {
                    dsbenhnhan.Clear();
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
                    ShowAllBenhnhan();
                }                           
            else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
         
        }
        void search()
        {
            string value = txtsearchbn.Text;
            if (!string.IsNullOrEmpty(value))
            {
                List<tblBenhnhan> ds = Sequencesearch(dsbenhnhan, value);
                dgvBenhnhan.DataSource = null;
                dgvBenhnhan.DataSource = ConvertListOjbectToDataTable(ds);
            }
            else
                ShowAllBenhnhan();
        }
        private void txtsearchbn_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void dgvBenhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMBN.Text = dgvBenhnhan.Rows[index].Cells["Mã bệnh nhân"].Value.ToString();
                txthotenbn.Text = dgvBenhnhan.Rows[index].Cells["Họ tên"].Value.ToString();
                date_ngaysinh.Text = dgvBenhnhan.Rows[index].Cells["Ngày sinh"].Value.ToString();
                txtgioitinh.Text = dgvBenhnhan.Rows[index].Cells["Giới tính"].Value.ToString();
                txtsdt.Text = dgvBenhnhan.Rows[index].Cells["Số điện thoại"].Value.ToString();
                txtdiachi.Text = dgvBenhnhan.Rows[index].Cells["Địa chỉ"].Value.ToString();
                txtghichu.Text = dgvBenhnhan.Rows[index].Cells["Ghi chú"].Value.ToString();
                date_ngaykham.Text = dgvBenhnhan.Rows[index].Cells["Ngày khám"].Value.ToString();

            }
        }
        private void sortbtn_Click(object sender, EventArgs e)
        {         
            Quick_Sort(dsbenhnhan, 0, dsbenhnhan.Count - 1);
            ShowAllBenhnhan();           
            //dgvBenhnhan.DataSource = ConvertListOjbectToDataTable(dsbenhnhan);

        }
        private void date_search_ValueChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
