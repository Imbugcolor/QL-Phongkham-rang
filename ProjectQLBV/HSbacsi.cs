using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectQLBV
{
    public partial class TableDr : Form
    {
        BacsiBLL bllBS;
        DataConnection dc;
        SqlDataAdapter da;
        List<tblBacsi> dsbacsi = new List<tblBacsi>();
        //QUICKSORT///////////////////////////////////////////////////////////////////////////////////////////QUICKSORT
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
                    while (string.Compare(list[leftIndex].hotenbs,pivot.hotenbs)<0 )
                    {
                        leftIndex++;
                    }
                    //check right values
                    while (string.Compare(list[rightIndex].hotenbs,pivot.hotenbs)>0 )
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
        public TableDr()
        {
            InitializeComponent();
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
                dsbacsi.Add(apha);
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
                dt.Rows.Add(bs.MS,bs.hotenbs,bs.Ngaysinh,bs.Gioitinh,bs.diachi,bs.sdt);
            }
            return dt;
        }
        public void ShowAllBacsi()
        {
            //DataTable dt = bllBS.getAllBacsi();
            //dgvBacsi.DataSource = dt;
            dgvBacsi.DataSource = null;
            dgvBacsi.DataSource = ConvertListOjbectToDataTable(dsbacsi);
        }

        private void sortbtn_Click(object sender, EventArgs e)
        {           
            Quick_Sort(dsbacsi, 0, dsbacsi.Count - 1);
            //ShowAllBacsi();
            dgvBacsi.DataSource = null;
            dgvBacsi.DataSource = ConvertListOjbectToDataTable(dsbacsi);
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void TableDr_Load(object sender, EventArgs e)
        {
            ShowAllBacsi();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMS.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMS.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txthotenbs.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthotenbs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(date_ngaysinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_ngaysinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGioitinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGioitinh.Focus();
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
            return true;
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblBacsi bs = new tblBacsi();
                bs.MS = txtMS.Text;
                bs.hotenbs = txthotenbs.Text;
                bs.Ngaysinh = date_ngaysinh.Value.Year + "-" + date_ngaysinh.Value.Month + "-" + date_ngaysinh.Value.Day;
                bs.Gioitinh = txtGioitinh.Text;
                bs.sdt = txtsdt.Text;
                bs.diachi = txtdiachi.Text;
                if (bllBS.InsertBacsi(bs))
                {
                    dsbacsi.Clear();
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
                        dsbacsi.Add(apha);
                    }
                    ShowAllBacsi();
                }
                else
                   MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }
        //private void SetMyButtonIcon()
        //{
        //}
        //string MBS;
        private void dgvBacsi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {               
                //MBS = dgvBacsi.Rows[index].Cells["MS"].Value.ToString();
                txtMS.Text = dgvBacsi.Rows[index].Cells["Mã Bác Sĩ"].Value.ToString();
                txthotenbs.Text = dgvBacsi.Rows[index].Cells["Họ và tên"].Value.ToString();
                date_ngaysinh.Text = dgvBacsi.Rows[index].Cells["Ngày sinh"].Value.ToString();
                txtGioitinh.Text = dgvBacsi.Rows[index].Cells["Giới tính"].Value.ToString();
                txtsdt.Text = dgvBacsi.Rows[index].Cells["Số điện thoại"].Value.ToString();
                txtdiachi.Text = dgvBacsi.Rows[index].Cells["Địa chỉ"].Value.ToString();
            }
        }
        private void repairbtn_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblBacsi bs = new tblBacsi();
                bs.MS = txtMS.Text;
                bs.hotenbs = txthotenbs.Text;
                bs.Ngaysinh = date_ngaysinh.Value.Year + "-" + date_ngaysinh.Value.Month + "-" + date_ngaysinh.Value.Day;
                bs.Gioitinh = txtGioitinh.Text;
                bs.sdt = txtsdt.Text;
                bs.diachi = txtdiachi.Text;
                if (bllBS.UpdateBacsi(bs))
                {
                    dsbacsi.Clear();
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
                        dsbacsi.Add(apha);
                    }
                    ShowAllBacsi();
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
                tblBacsi bs = new tblBacsi();
                bs.MS = txtMS.Text;
                if (bllBS.DeleteBacsi(bs))
                {
                    dsbacsi.Clear();
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
                        dsbacsi.Add(apha);
                    }
                    ShowAllBacsi();
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);               

            }
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string value = txtsearch.Text;
            //DataTable dt = bllBS.getAllBacsi();
            //dsbacsi.Clear();
            //List<tblBacsi> tmp = Seqsearch(dsbacsi, value);
            //foreach (DataRow row in dt.Rows)
            //{
            //    tblBacsi apha = new tblBacsi();
            //    apha.MS = Tostring(row, 0);
            //    apha.hotenbs = Tostring(row, 1);
            //    apha.Ngaysinh = Tostring(row, 2);
            //    apha.Gioitinh = Tostring(row, 3);
            //    apha.sdt = Tostring(row, 4);
            //    apha.diachi = Tostring(row, 5);
            //    dsbacsi.Add(apha);
            //}
            //ShowAllBacsi();

            if (!string.IsNullOrEmpty(value))
            {
                List<tblBacsi> ds = Sequencesearch(dsbacsi, value);
                dgvBacsi.DataSource = null;
                dgvBacsi.DataSource = ConvertListOjbectToDataTable(ds);
            }
            else
            {
                ShowAllBacsi();
            }
        }
    }
}
