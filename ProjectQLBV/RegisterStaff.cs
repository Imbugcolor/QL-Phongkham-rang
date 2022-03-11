using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLBV
{
    public partial class RegisterStaff : Form
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public RegisterStaff()
        {
            InitializeComponent();
            dc = new DataConnection();
        }

        private void RegisterStaff_Load(object sender, EventArgs e)
        {

        }

        private void textUserStffname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textUserStffcfm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textUserStffpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(textUserStffname.Text=="" && textUserStffpass.Text=="" )
            {   
                MessageBox.Show("Username hoặc Password đang trống", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            else if (textUserStffpass.Text == textUserStffcfm.Text && textBoxVrfctcde.Text=="admin001")
            {
                string sql = "select COUNT(*) from [staff_user] where namestaff=@namestaff";
                SqlConnection con = dc.getConnect();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@namestaff", textUserStffname.Text));
                int x = (int)cmd.ExecuteScalar();
                if (x == 0)
                {
                    string sql2 = "INSERT INTO [staff_user] VALUES ('" + textUserStffname.Text + "','" + MD5Hash(textUserStffpass.Text) + "') ";
                    //SqlConnection con2 = dc.getConnect();
                    //con2.Open();
                    cmd = new SqlCommand(sql2, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    textUserStffname.Text = "";
                    textUserStffpass.Text = "";
                    textUserStffcfm.Text = "";
                    textBoxVrfctcde.Text = "";
                    MessageBox.Show("Đăng ký tài khoản thành công", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                    MessageBox.Show("Tên đăng nhập đã có người dùng", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
            else
            {   
                MessageBox.Show("Password hoặc mã xác nhận chưa hợp lệ, hãy thử lại", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUserStffpass.Text = "";
                textUserStffcfm.Text = "";
                textBoxVrfctcde.Text = "";
                textUserStffpass.Focus();                
            }

        }
        //MD5 Hash*****************************************MD5 Hash*************************************MD5Hash
        public static string MD5Hash(string input)
        {
            //Tạo đối tượng mã hóa
            StringBuilder hash = new StringBuilder(); //O(1)
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider(); //O(1)
            //mã hóa mảng byte bằng MD5
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input)); //O(1)
            //chuyển mảng byte thành chuỗi
            for (int i = 0; i < bytes.Length; i++) //O(N)
            {
                hash.Append(bytes[i].ToString("x2")); //O(N)
            }
            return hash.ToString(); //O(1)
        }
        private void checkBoxShowpss_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowpss.Checked)
            {
                textUserStffpass.PasswordChar = '\0';
                textUserStffcfm.PasswordChar = '\0';
            }
            else {
                textUserStffpass.PasswordChar = '*';
                textUserStffcfm.PasswordChar = '*';
            }
        }

        private void btnReadyLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
        }
    }
}
