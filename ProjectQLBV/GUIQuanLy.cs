using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLBV
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
        }

        private void TableManager_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TableDr Dr = new TableDr();
            Dr.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TableBN Bn = new TableBN();
            Bn.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WorkCalender Wc =new WorkCalender();
            Wc.ShowDialog();
        }
        private void TableManager_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Size=new Size(270, 270);
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Cursor = Cursors.Default;
            pictureBox1.Size = new Size(256, 256);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Size = new Size(270, 270);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Cursor = Cursors.Default;
            pictureBox2.Size = new Size(256, 256);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Size = new Size(270, 270);

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Cursor = Cursors.Default;
            pictureBox3.Size = new Size(256, 256);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Thongke TK = new Thongke();
            TK.ShowDialog();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Size = new Size(270, 270);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Cursor = Cursors.Default;
            pictureBox4.Size = new Size(256, 256);

        }

        private void hsbn_Click(object sender, EventArgs e)
        {

        }

    }
}
