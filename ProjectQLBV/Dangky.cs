using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLBV
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
            customizeDesign();
            SidePanel.Height = btnBacsi.Height;
            SidePanel.Top = btnBacsi.Top;
            timer1.Start();
        }
        private void customizeDesign()
        {
            panelMenuBacsi.Visible = false;
            pannelMenuBN.Visible = false;
            panelMenuLich.Visible = false;
            panelMenuDK.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelMenuBacsi.Visible == true)
                panelMenuBacsi.Visible = false;
            if (pannelMenuBN.Visible == true)
                pannelMenuBN.Visible = false;
            if (panelMenuLich.Visible == true)
                panelMenuLich.Visible = false;
            if (panelMenuDK.Visible == true)
                panelMenuDK.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
//Menu Bac si
        private void buttonCustmize_Click(object sender, EventArgs e){
            SidePanel.Height = btnBacsi.Height;
            SidePanel.Top = btnBacsi.Top;
            showSubMenu(panelMenuBacsi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new ClddsBacsi());
            //Your code
            //...
            //hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Cldbacsi2());
            //Your code
            //...
            //hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Your code
            //...
            //hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Your code
            //...
            //hideSubMenu();
        }

   
//Menu Benh nhan
        private void btnBenhnhan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnBenhnhan.Height;
            SidePanel.Top = btnBenhnhan.Top;
            showSubMenu(pannelMenuBN);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new ClddsBenhNhan());
            //Your code
            //...
            //hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Your code
            //...
            //hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Your code
            //...
            //hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Your code
            //...
            //hideSubMenu();
        }
//Menu Lich lam viec
        private void button11_Click(object sender, EventArgs e)
        {
            WorkCalender wc = new WorkCalender();
            wc.Show();
            //Your code
            //...
            //hideSubMenu();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnLich.Height;
            SidePanel.Top = btnLich.Top;
            showSubMenu(panelMenuLich);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //Your code
            //...
            //hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Your code
            //...
            //hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Your code
            //...
            //hideSubMenu();
        }
//MenuDangkykham
        private void btnDK_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDK.Height;
            SidePanel.Top = btnDK.Top;
            showSubMenu(panelMenuDK);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openChildForm(new DKkhambenh());
            //Your code
            //...
            //hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            openChildForm(new LichDKKB());           
            //Your code
            //...
            //hideSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Your code
            //...
            //hideSubMenu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //Your code
            //...
            //hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormBS.Controls.Add(childForm);
            panelChildFormBS.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();        
        }

        private void Dangky_Load(object sender, EventArgs e)
        {

        }
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void btn_fb_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.facebook.com/DHviet18/");
        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
            OpenUrl("https://mail.google.com/");
        }

        private void btn_twt_Click(object sender, EventArgs e)
        {
            OpenUrl("https://twitter.com/Vietdin24522932");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
