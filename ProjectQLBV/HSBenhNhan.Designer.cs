
namespace ProjectQLBV
{
    partial class TableBN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableBN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_ngaykham = new System.Windows.Forms.DateTimePicker();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.sortbtn = new System.Windows.Forms.Button();
            this.imlbtn = new System.Windows.Forms.ImageList(this.components);
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.txthotenbn = new System.Windows.Forms.TextBox();
            this.txtMBN = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.lbdatecheck = new System.Windows.Forms.Label();
            this.lbnote = new System.Windows.Forms.Label();
            this.lbaddr = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.tenbn = new System.Windows.Forms.Label();
            this.mabn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtsearchbn = new System.Windows.Forms.TextBox();
            this.lbsearchbn = new System.Windows.Forms.Label();
            this.repairbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBenhnhan = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhnhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.date_ngaykham);
            this.panel1.Controls.Add(this.date_ngaysinh);
            this.panel1.Controls.Add(this.sortbtn);
            this.panel1.Controls.Add(this.txtghichu);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.txtgioitinh);
            this.panel1.Controls.Add(this.txthotenbn);
            this.panel1.Controls.Add(this.txtMBN);
            this.panel1.Controls.Add(this.txt);
            this.panel1.Controls.Add(this.lbdatecheck);
            this.panel1.Controls.Add(this.lbnote);
            this.panel1.Controls.Add(this.lbaddr);
            this.panel1.Controls.Add(this.lbsdt);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.birthday);
            this.panel1.Controls.Add(this.tenbn);
            this.panel1.Controls.Add(this.mabn);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 186);
            this.panel1.TabIndex = 1;
            // 
            // date_ngaykham
            // 
            this.date_ngaykham.Location = new System.Drawing.Point(471, 147);
            this.date_ngaykham.Name = "date_ngaykham";
            this.date_ngaykham.Size = new System.Drawing.Size(200, 23);
            this.date_ngaykham.TabIndex = 27;
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Location = new System.Drawing.Point(104, 108);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(186, 23);
            this.date_ngaysinh.TabIndex = 26;
            // 
            // sortbtn
            // 
            this.sortbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sortbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sortbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortbtn.ImageIndex = 7;
            this.sortbtn.ImageList = this.imlbtn;
            this.sortbtn.Location = new System.Drawing.Point(219, 140);
            this.sortbtn.Name = "sortbtn";
            this.sortbtn.Size = new System.Drawing.Size(84, 40);
            this.sortbtn.TabIndex = 25;
            this.sortbtn.Text = "Sắp xếp";
            this.sortbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sortbtn.UseVisualStyleBackColor = true;
            this.sortbtn.Click += new System.EventHandler(this.sortbtn_Click);
            // 
            // imlbtn
            // 
            this.imlbtn.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlbtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlbtn.ImageStream")));
            this.imlbtn.TransparentColor = System.Drawing.Color.Transparent;
            this.imlbtn.Images.SetKeyName(0, "Icojam-Blue-Bits-User-add.ico");
            this.imlbtn.Images.SetKeyName(1, "Graphicloads-Colorful-Long-Shadow-Button-7-close.ico");
            this.imlbtn.Images.SetKeyName(2, "Etherbrian-Webuosities-Fix-it.ico");
            this.imlbtn.Images.SetKeyName(3, "Oxygen-Icons.org-Oxygen-Actions-view-sort-ascending.ico");
            this.imlbtn.Images.SetKeyName(4, "cancel (1).png");
            this.imlbtn.Images.SetKeyName(5, "edit.png");
            this.imlbtn.Images.SetKeyName(6, "Tick.ico");
            this.imlbtn.Images.SetKeyName(7, "sort-descending.png");
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(444, 108);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(162, 23);
            this.txtghichu.TabIndex = 23;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(444, 69);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(281, 23);
            this.txtdiachi.TabIndex = 22;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(523, 25);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(162, 23);
            this.txtsdt.TabIndex = 21;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(104, 147);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(64, 23);
            this.txtgioitinh.TabIndex = 20;
            // 
            // txthotenbn
            // 
            this.txthotenbn.Location = new System.Drawing.Point(128, 67);
            this.txthotenbn.Name = "txthotenbn";
            this.txthotenbn.Size = new System.Drawing.Size(162, 23);
            this.txthotenbn.TabIndex = 18;
            // 
            // txtMBN
            // 
            this.txtMBN.Location = new System.Drawing.Point(128, 25);
            this.txtMBN.Name = "txtMBN";
            this.txtMBN.Size = new System.Drawing.Size(94, 23);
            this.txtMBN.TabIndex = 17;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt.Location = new System.Drawing.Point(255, 6);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(227, 22);
            this.txt.TabIndex = 16;
            this.txt.Text = "DANH MỤC BỆNH NHÂN";
            // 
            // lbdatecheck
            // 
            this.lbdatecheck.AutoSize = true;
            this.lbdatecheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdatecheck.Location = new System.Drawing.Point(367, 153);
            this.lbdatecheck.Name = "lbdatecheck";
            this.lbdatecheck.Size = new System.Drawing.Size(72, 15);
            this.lbdatecheck.TabIndex = 14;
            this.lbdatecheck.Text = "Ngày khám:";
            // 
            // lbnote
            // 
            this.lbnote.AutoSize = true;
            this.lbnote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnote.Location = new System.Drawing.Point(367, 114);
            this.lbnote.Name = "lbnote";
            this.lbnote.Size = new System.Drawing.Size(52, 15);
            this.lbnote.TabIndex = 12;
            this.lbnote.Text = "Ghi chú:";
            // 
            // lbaddr
            // 
            this.lbaddr.AutoSize = true;
            this.lbaddr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbaddr.Location = new System.Drawing.Point(367, 72);
            this.lbaddr.Name = "lbaddr";
            this.lbaddr.Size = new System.Drawing.Size(47, 15);
            this.lbaddr.TabIndex = 10;
            this.lbaddr.Text = "Địa chỉ:";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbsdt.Location = new System.Drawing.Point(367, 31);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(116, 15);
            this.lbsdt.TabIndex = 8;
            this.lbsdt.Text = "Số điện thoại (+84):";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gender.Location = new System.Drawing.Point(16, 152);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(58, 15);
            this.gender.TabIndex = 6;
            this.gender.Text = "Giới tính:";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthday.Location = new System.Drawing.Point(16, 111);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(63, 15);
            this.birthday.TabIndex = 4;
            this.birthday.Text = "Ngày sinh:";
            // 
            // tenbn
            // 
            this.tenbn.AutoSize = true;
            this.tenbn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tenbn.Location = new System.Drawing.Point(16, 69);
            this.tenbn.Name = "tenbn";
            this.tenbn.Size = new System.Drawing.Size(91, 15);
            this.tenbn.TabIndex = 2;
            this.tenbn.Text = "Tên bệnh nhân:";
            // 
            // mabn
            // 
            this.mabn.AutoSize = true;
            this.mabn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mabn.Location = new System.Drawing.Point(16, 28);
            this.mabn.Name = "mabn";
            this.mabn.Size = new System.Drawing.Size(88, 15);
            this.mabn.TabIndex = 0;
            this.mabn.Text = "Mã bệnh nhân:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtsearchbn);
            this.panel2.Controls.Add(this.lbsearchbn);
            this.panel2.Controls.Add(this.repairbtn);
            this.panel2.Controls.Add(this.removebtn);
            this.panel2.Controls.Add(this.addbtn);
            this.panel2.Location = new System.Drawing.Point(12, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 40);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(500, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtsearchbn
            // 
            this.txtsearchbn.Location = new System.Drawing.Point(543, 10);
            this.txtsearchbn.Name = "txtsearchbn";
            this.txtsearchbn.Size = new System.Drawing.Size(172, 23);
            this.txtsearchbn.TabIndex = 5;
            this.txtsearchbn.TextChanged += new System.EventHandler(this.txtsearchbn_TextChanged);
            // 
            // lbsearchbn
            // 
            this.lbsearchbn.AutoSize = true;
            this.lbsearchbn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbsearchbn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbsearchbn.Location = new System.Drawing.Point(432, 13);
            this.lbsearchbn.Name = "lbsearchbn";
            this.lbsearchbn.Size = new System.Drawing.Size(62, 15);
            this.lbsearchbn.TabIndex = 4;
            this.lbsearchbn.Text = "Tìm kiếm:";
            // 
            // repairbtn
            // 
            this.repairbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.repairbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.repairbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.repairbtn.ImageIndex = 5;
            this.repairbtn.ImageList = this.imlbtn;
            this.repairbtn.Location = new System.Drawing.Point(303, 0);
            this.repairbtn.Name = "repairbtn";
            this.repairbtn.Size = new System.Drawing.Size(97, 40);
            this.repairbtn.TabIndex = 3;
            this.repairbtn.Text = "Sửa";
            this.repairbtn.UseVisualStyleBackColor = true;
            this.repairbtn.Click += new System.EventHandler(this.repairbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removebtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.removebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removebtn.ImageIndex = 4;
            this.removebtn.ImageList = this.imlbtn;
            this.removebtn.Location = new System.Drawing.Point(151, 0);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(97, 40);
            this.removebtn.TabIndex = 1;
            this.removebtn.Text = "Xóa";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbtn.ImageIndex = 6;
            this.addbtn.ImageList = this.imlbtn;
            this.addbtn.Location = new System.Drawing.Point(0, 0);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(97, 40);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Thêm";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBenhnhan);
            this.panel3.Location = new System.Drawing.Point(12, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(763, 207);
            this.panel3.TabIndex = 18;
            // 
            // dgvBenhnhan
            // 
            this.dgvBenhnhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBenhnhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBenhnhan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhnhan.Location = new System.Drawing.Point(0, 0);
            this.dgvBenhnhan.Name = "dgvBenhnhan";
            this.dgvBenhnhan.RowHeadersWidth = 51;
            this.dgvBenhnhan.RowTemplate.Height = 25;
            this.dgvBenhnhan.Size = new System.Drawing.Size(763, 207);
            this.dgvBenhnhan.TabIndex = 0;
            this.dgvBenhnhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhnhan_CellClick);
            this.dgvBenhnhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhnhan_CellContentClick);
            // 
            // TableBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableBN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hồ sơ bệnh nhân";
            this.Load += new System.EventHandler(this.TableBN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhnhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label lbdatecheck;
        private System.Windows.Forms.Label lbnote;
        private System.Windows.Forms.Label lbaddr;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label tenbn;
        private System.Windows.Forms.Label mabn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button repairbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBenhnhan;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.TextBox txthotenbn;
        private System.Windows.Forms.TextBox txtMBN;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txtsearchbn;
        private System.Windows.Forms.Label lbsearchbn;
        private System.Windows.Forms.Button sortbtn;
        private System.Windows.Forms.ImageList imlbtn;
        private System.Windows.Forms.DateTimePicker date_ngaykham;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}