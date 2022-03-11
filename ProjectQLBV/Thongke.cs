using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLBV
{
    public partial class Thongke : Form
    {
        BenhnhanBLL bllBN;
        List<tblBenhnhan> dsbenhnhan = new List<tblBenhnhan>();
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
        private string Tostring(DataRow row, int i)
        {
            return row.ItemArray[i].ToString().Trim();
        }  
        //SAPXEPCHENNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
        List<tblBenhnhan> insertionSort(string date)
        {
            //Tạo danh sách mới
            List<tblBenhnhan> ds = new List<tblBenhnhan>(); //1
            //thêm các bệnh nhân có cùng ngày khám và thực hiện sort ds
            foreach(tblBenhnhan apha in dsbenhnhan) //N
            {
                if(apha.ngaykham == date) //1
                {
                    ds.Add(apha); //1
                }
            }
            ds.Sort(
                delegate (tblBenhnhan a, tblBenhnhan b) //1
                {
                    return a.hotenbn.CompareTo(b.hotenbn); //1
                }
            );
            return ds; //1
        }

        string date()
        {
            return date_thongke.Value.Year + "-" + date_thongke.Value.Month + "-" + date_thongke.Value.Day;
        }
        public Thongke()
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ConvertListOjbectToDataTable(insertionSort(date()));
        }
        private void date_thongke_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ConvertListOjbectToDataTable(insertionSort(date()));
        }
        private void prevbtn_Click(object sender, EventArgs e)
        {
            date_thongke.Value = date_thongke.Value.AddDays(-1);
        }
        private void nxtbtn_Click(object sender, EventArgs e)
        {
            date_thongke.Value = date_thongke.Value.AddDays(1);
        }
    }
}
