using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQLBV
{
    public partial class Login : Form
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public Login()
        {         
            InitializeComponent();
            dc = new DataConnection();
            // Set to no text.
            txtPassword.Text = "";
            // The password character is an asterisk.
            txtPassword.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtPassword.MaxLength = 14;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (checkMnger.Checked)
            {
                string sql = "select COUNT(*) from [user] where username=@username and password=@password";
                SqlConnection con = dc.getConnect();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@username", txtUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@password", txtPassword.Text));
                int x = (int)cmd.ExecuteScalar();
                if (x == 1)
                {
                    //MessageBox.Show("Đăng nhập thành công");
                    TableManager f = new TableManager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                con.Close();
            }
            else if (checkStff.Checked)
            {
                string sql = "select COUNT(*) from [staff_user] where namestaff=@namestaff and passstaff='"+MD5Hash(txtPassword.Text)+"'";
                SqlConnection con = dc.getConnect();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@namestaff", txtUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@passstaff", txtPassword.Text));
                int x = (int)cmd.ExecuteScalar();
                if (x == 1)
                {
                    //MessageBox.Show("Đăng nhập thành công");
                    Dangky dk = new Dangky();
                    this.Hide();
                    dk.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                con.Close();
            }
            else
                MessageBox.Show("Bạn chưa chọn quyền truy cập");
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        private void exitbtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkMnger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMnger.Checked == true)
                checkStff.Checked = false;
        }

        private void checkStff_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStff.Checked == true)
                checkMnger.Checked = false;
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            RegisterStaff RS = new RegisterStaff();
            this.Hide();
            RS.ShowDialog();
            this.Show();
        }

        private void lbRegister_MouseEnter(object sender, EventArgs e)
        {
            lbRegister.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);               ;
        }

        private void lbRegister_MouseLeave(object sender, EventArgs e)
        {
            lbRegister.ForeColor = System.Drawing.Color.FromArgb(0,117,214);
        }
    }
}
