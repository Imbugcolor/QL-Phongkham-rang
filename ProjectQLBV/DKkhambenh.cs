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
    public partial class DKkhambenh : Form
    {
        DKDLL bllDK;
        DataConnection dc;
        SqlDataAdapter da;
        List<tblDangkykb> dsdk = new List<tblDangkykb>();
        private string Tostring(DataRow row, int i)
        {
            return row.ItemArray[i].ToString().Trim();
        }
        //TIMKIEMTUANTU////////////////////////////////////////////////////////////TIMKIEMTUANTU
        List<tblDangkykb> Sequencesearch(List<tblDangkykb> list, string infor)
        {
            List<tblDangkykb> tmp = new List<tblDangkykb>();
            foreach (var m in list)
            {
                if (m.hotendk.ToLower().Contains(infor.ToLower()) || m.Madk.ToLower().Contains(infor.ToLower()))
                    tmp.Add(m);
            }
            return tmp;
        }
        public DKkhambenh()
        {
            InitializeComponent();
            bllDK = new DKDLL();
            DataTable dt = bllDK.getAllDK();
            foreach (DataRow row in dt.Rows)
            {
                tblDangkykb apha = new tblDangkykb();
                apha.Madk = Tostring(row, 0);
                apha.hotendk = Tostring(row, 1);
                apha.thoigiandk = Tostring(row, 2);
                apha.thoigianhen = Tostring(row, 3);
                apha.buoihen = Tostring(row, 4);
                apha.sdtdk = Tostring(row, 5);
                apha.ghichudk = Tostring(row, 6);
                dsdk.Add(apha);
            }
            time_lab.Start();
            cbb_buoihenkham.SelectedIndex = 0;
        }
        private DataTable ConvertListOjbectToDataTable(List<tblDangkykb> objectClass)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Đăng ký");
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Thời gian ĐK");
            dt.Columns.Add("Thời gian hẹn");
            dt.Columns.Add("Buổi hẹn");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Ghi chú");
            foreach (tblDangkykb dk in objectClass)
            {
                dt.Rows.Add(dk.Madk, dk.hotendk, dk.thoigiandk, dk.thoigianhen,dk.buoihen, dk.sdtdk, dk.ghichudk);
            }
            return dt;
        }
        public void ShowAllDK()
        {
            //DataTable dt = bllBS.getAllBacsi();
            //dgvBacsi.DataSource = dt;
            dgv_dangky.DataSource = null;
            dgv_dangky.DataSource = ConvertListOjbectToDataTable(dsdk);
        }

        private void txt_Sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DKkhambenh_Load(object sender, EventArgs e)
        {
            ShowAllDK();
            dgv_dangky.BorderStyle = BorderStyle.None;
            dgv_dangky.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_dangky.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_dangky.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv_dangky.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_dangky.BackgroundColor = Color.White;

            dgv_dangky.EnableHeadersVisualStyles = false;
            dgv_dangky.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_dangky.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_dangky.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dgv_dangky_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_dangky_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //MBS = dgvBacsi.Rows[index].Cells["MS"].Value.ToString();
                txt_madk.Text = dgv_dangky.Rows[index].Cells["Mã Đăng ký"].Value.ToString();
                txt_hoten.Text = dgv_dangky.Rows[index].Cells["Họ và tên"].Value.ToString();
                date_dangky.Text = dgv_dangky.Rows[index].Cells["Thời gian ĐK"].Value.ToString();
                date_henkham.Text = dgv_dangky.Rows[index].Cells["Thời gian hẹn"].Value.ToString();
                //txt_buoihen.Text = dgv_dangky.Rows[index].Cells["Buổi hẹn"].Value.ToString();
                cbb_buoihenkham.Text = dgv_dangky.Rows[index].Cells["Buổi hẹn"].Value.ToString();
                txt_Sdt.Text = dgv_dangky.Rows[index].Cells["Số điện thoại"].Value.ToString();
                txt_ghichu.Text = dgv_dangky.Rows[index].Cells["Ghi chú"].Value.ToString();
            }
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txt_madk.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_madk.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_hoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_hoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(date_dangky.Text))
            {
                MessageBox.Show("Bạn chưa nhập thời gian đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_dangky.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(date_henkham.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày hẹn khám.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_henkham.Focus();
                return false;
            }
            if(DateTime.Parse(date_dangky.Text) > DateTime.Parse(date_henkham.Text))
            {
                MessageBox.Show("Thời gian đăng ký với hẹn khám chưa hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_henkham.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbb_buoihenkham.Text))
            {
                MessageBox.Show("Bạn chưa chọn buổi hẹn khám.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_buoihenkham.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_Sdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Sdt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_ghichu.Text))
            {
                MessageBox.Show("Bạn chưa nhập ghi chú.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ghichu.Focus();
                return false;
            }
            return true;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblDangkykb dk = new tblDangkykb();
                dk.Madk = txt_madk.Text;
                dk.hotendk = txt_hoten.Text;
                dk.thoigiandk = date_dangky.Value.Year + "-" + date_dangky.Value.Month + "-" + date_dangky.Value.Day + " " + date_dangky.Value.Hour + ":" + date_dangky.Value.Minute;
                dk.thoigianhen = date_henkham.Value.Year+"-"+date_henkham.Value.Month+"-"+date_henkham.Value.Day;
                dk.buoihen = cbb_buoihenkham.Text;
                dk.sdtdk = txt_Sdt.Text;
                dk.ghichudk = txt_ghichu.Text;
                if (bllDK.InsertDK(dk))
                {
                    dsdk.Clear();
                    DataTable dt = bllDK.getAllDK();
                    foreach (DataRow row in dt.Rows)
                    {
                        tblDangkykb apha = new tblDangkykb();
                        apha.Madk = Tostring(row, 0);
                        apha.hotendk = Tostring(row, 1);
                        apha.thoigiandk = Tostring(row, 2);
                        apha.thoigianhen = Tostring(row, 3);
                        apha.buoihen = Tostring(row, 4);
                        apha.sdtdk = Tostring(row, 5);
                        apha.ghichudk = Tostring(row, 6);
                        dsdk.Add(apha);
                    }
                    ShowAllDK();
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                if (CheckData())
                {
                    tblDangkykb dk = new tblDangkykb();
                    dk.Madk = txt_madk.Text;
                    dk.hotendk = txt_hoten.Text;
                    dk.thoigiandk = date_dangky.Value.Year + "-" + date_dangky.Value.Month + "-" + date_dangky.Value.Day + " " + date_dangky.Value.Hour + ":" + date_dangky.Value.Minute;
                    dk.thoigianhen = date_henkham.Value.Year + "-" + date_henkham.Value.Month + "-" + date_henkham.Value.Day;
                    dk.buoihen = cbb_buoihenkham.Text;
                    dk.sdtdk = txt_Sdt.Text;
                    dk.ghichudk = txt_ghichu.Text;
                    if (bllDK.DeleteDK(dk))
                    {
                        dsdk.Clear();
                        DataTable dt = bllDK.getAllDK();
                        foreach (DataRow row in dt.Rows)
                        {
                            tblDangkykb apha = new tblDangkykb();
                            apha.Madk = Tostring(row, 0);
                            apha.hotendk = Tostring(row, 1);
                            apha.thoigiandk = Tostring(row, 2);
                            apha.thoigianhen = Tostring(row, 3);
                            apha.buoihen  = Tostring(row, 4);
                            apha.sdtdk = Tostring(row, 5);
                            apha.ghichudk = Tostring(row, 6);
                            dsdk.Add(apha);
                        }
                        ShowAllDK();
                    }
                    else
                        MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btn_repair_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblDangkykb dk = new tblDangkykb();
                dk.Madk = txt_madk.Text;
                dk.hotendk = txt_hoten.Text;
                dk.thoigiandk = date_dangky.Value.Year + "-" + date_dangky.Value.Month + "-" + date_dangky.Value.Day + " " + date_dangky.Value.Hour + ":" + date_dangky.Value.Minute;
                dk.thoigianhen = date_henkham.Value.Year + "-" + date_henkham.Value.Month + "-" + date_henkham.Value.Day;
                dk.buoihen = cbb_buoihenkham.Text;
                dk.sdtdk = txt_Sdt.Text;
                dk.ghichudk = txt_ghichu.Text;
                    if (bllDK.UpdateDK(dk))
                    {
                        dsdk.Clear();
                        DataTable dt = bllDK.getAllDK();
                        foreach (DataRow row in dt.Rows)
                        {
                            tblDangkykb apha = new tblDangkykb();
                            apha.Madk = Tostring(row, 0);
                            apha.hotendk = Tostring(row, 1);
                            apha.thoigiandk = Tostring(row, 2);
                            apha.thoigianhen = Tostring(row, 3);
                            apha.buoihen = Tostring(row, 4);
                            apha.sdtdk = Tostring(row, 5);
                            apha.ghichudk = Tostring(row, 6);
                            dsdk.Add(apha);
                        }
                        ShowAllDK();
                    }
                    else
                        MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }

            }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string value = txt_searchdk.Text;

            if (!string.IsNullOrEmpty(value))
            {
                List<tblDangkykb> dk = Sequencesearch(dsdk, value);
                dgv_dangky.DataSource = null;
                dgv_dangky.DataSource = ConvertListOjbectToDataTable(dk);
            }
            else
            {
                ShowAllDK();
            }
        }

        private void time_lab_Tick(object sender, EventArgs e)
        {
            date_dangky.Value = DateTime.Now;
            lab_hour.Text = date_dangky.Value.Hour + ":" + date_dangky.Value.Minute + ":" + date_dangky.Value.Second;
        }
        DateTime dateTimeConver()
        {
            if(cbb_buoihenkham.SelectedIndex == 0)
            {
                DateTime apha = new DateTime(date_henkham.Value.Year, date_henkham.Value.Month, date_henkham.Value.Day, 5, 0, 0);
                return apha;
            }
            else if (cbb_buoihenkham.SelectedIndex == 1)
            {
                DateTime apha = new DateTime(date_henkham.Value.Year, date_henkham.Value.Month, date_henkham.Value.Day, 13, 0, 0);
                return apha;
            }
            else
            {
                DateTime apha = new DateTime(date_henkham.Value.Year, date_henkham.Value.Month, date_henkham.Value.Day, 18, 0, 0);
                return apha;
            }
        }
        private void date_henkham_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeConver() < date_dangky.Value)
            {
                date_henkham.Value = DateTime.Now.AddDays(1);
            }
        }
    }
}
