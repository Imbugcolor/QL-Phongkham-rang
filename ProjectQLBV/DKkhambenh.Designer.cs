
namespace ProjectQLBV
{
    partial class DKkhambenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DKkhambenh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_hour = new System.Windows.Forms.Label();
            this.cbb_buoihenkham = new System.Windows.Forms.ComboBox();
            this.lb_buoihen = new System.Windows.Forms.Label();
            this.txt_madk = new System.Windows.Forms.TextBox();
            this.lb_madk = new System.Windows.Forms.Label();
            this.date_henkham = new System.Windows.Forms.DateTimePicker();
            this.date_dangky = new System.Windows.Forms.DateTimePicker();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.lb_timedk = new System.Windows.Forms.Label();
            this.lb_timehen = new System.Windows.Forms.Label();
            this.lb_ghichu = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_Hoten = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_dangky = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_searchdk = new System.Windows.Forms.TextBox();
            this.lb_find = new System.Windows.Forms.Label();
            this.btn_repair = new System.Windows.Forms.Button();
            this.imlbtn = new System.Windows.Forms.ImageList(this.components);
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.time_lab = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dangky)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lab_hour);
            this.panel1.Controls.Add(this.cbb_buoihenkham);
            this.panel1.Controls.Add(this.lb_buoihen);
            this.panel1.Controls.Add(this.txt_madk);
            this.panel1.Controls.Add(this.lb_madk);
            this.panel1.Controls.Add(this.date_henkham);
            this.panel1.Controls.Add(this.date_dangky);
            this.panel1.Controls.Add(this.txt_ghichu);
            this.panel1.Controls.Add(this.txt_Sdt);
            this.panel1.Controls.Add(this.txt_hoten);
            this.panel1.Controls.Add(this.lb_timedk);
            this.panel1.Controls.Add(this.lb_timehen);
            this.panel1.Controls.Add(this.lb_ghichu);
            this.panel1.Controls.Add(this.lb_sdt);
            this.panel1.Controls.Add(this.lb_Hoten);
            this.panel1.Location = new System.Drawing.Point(14, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 205);
            this.panel1.TabIndex = 1;
            // 
            // lab_hour
            // 
            this.lab_hour.AutoSize = true;
            this.lab_hour.Location = new System.Drawing.Point(298, 113);
            this.lab_hour.Name = "lab_hour";
            this.lab_hour.Size = new System.Drawing.Size(16, 20);
            this.lab_hour.TabIndex = 9;
            this.lab_hour.Text = "?";
            // 
            // cbb_buoihenkham
            // 
            this.cbb_buoihenkham.FormattingEnabled = true;
            this.cbb_buoihenkham.Items.AddRange(new object[] {
            "Sáng",
            "Chiều",
            "Tối"});
            this.cbb_buoihenkham.Location = new System.Drawing.Point(491, 12);
            this.cbb_buoihenkham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_buoihenkham.Name = "cbb_buoihenkham";
            this.cbb_buoihenkham.Size = new System.Drawing.Size(95, 28);
            this.cbb_buoihenkham.TabIndex = 8;
            this.cbb_buoihenkham.SelectedIndexChanged += new System.EventHandler(this.date_henkham_ValueChanged);
            // 
            // lb_buoihen
            // 
            this.lb_buoihen.AutoSize = true;
            this.lb_buoihen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_buoihen.Location = new System.Drawing.Point(392, 19);
            this.lb_buoihen.Name = "lb_buoihen";
            this.lb_buoihen.Size = new System.Drawing.Size(75, 18);
            this.lb_buoihen.TabIndex = 7;
            this.lb_buoihen.Text = "Buổi hẹn:";
            // 
            // txt_madk
            // 
            this.txt_madk.Location = new System.Drawing.Point(131, 12);
            this.txt_madk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_madk.Name = "txt_madk";
            this.txt_madk.Size = new System.Drawing.Size(125, 27);
            this.txt_madk.TabIndex = 1;
            // 
            // lb_madk
            // 
            this.lb_madk.AutoSize = true;
            this.lb_madk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_madk.Location = new System.Drawing.Point(23, 16);
            this.lb_madk.Name = "lb_madk";
            this.lb_madk.Size = new System.Drawing.Size(102, 18);
            this.lb_madk.TabIndex = 6;
            this.lb_madk.Text = "Mã Đăng ký:";
            // 
            // date_henkham
            // 
            this.date_henkham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_henkham.Location = new System.Drawing.Point(178, 155);
            this.date_henkham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_henkham.Name = "date_henkham";
            this.date_henkham.Size = new System.Drawing.Size(114, 27);
            this.date_henkham.TabIndex = 4;
            this.date_henkham.ValueChanged += new System.EventHandler(this.date_henkham_ValueChanged);
            // 
            // date_dangky
            // 
            this.date_dangky.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.date_dangky.Enabled = false;
            this.date_dangky.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_dangky.Location = new System.Drawing.Point(178, 108);
            this.date_dangky.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_dangky.Name = "date_dangky";
            this.date_dangky.Size = new System.Drawing.Size(114, 27);
            this.date_dangky.TabIndex = 3;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(467, 125);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(273, 48);
            this.txt_ghichu.TabIndex = 7;
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(568, 64);
            this.txt_Sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(172, 27);
            this.txt_Sdt.TabIndex = 6;
            this.txt_Sdt.TextChanged += new System.EventHandler(this.txt_Sdt_TextChanged);
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(113, 64);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(246, 27);
            this.txt_hoten.TabIndex = 2;
            // 
            // lb_timedk
            // 
            this.lb_timedk.AutoSize = true;
            this.lb_timedk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_timedk.Location = new System.Drawing.Point(23, 116);
            this.lb_timedk.Name = "lb_timedk";
            this.lb_timedk.Size = new System.Drawing.Size(143, 18);
            this.lb_timedk.TabIndex = 0;
            this.lb_timedk.Text = "Thời gian đăng ký:";
            // 
            // lb_timehen
            // 
            this.lb_timehen.AutoSize = true;
            this.lb_timehen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_timehen.Location = new System.Drawing.Point(23, 163);
            this.lb_timehen.Name = "lb_timehen";
            this.lb_timehen.Size = new System.Drawing.Size(155, 18);
            this.lb_timehen.TabIndex = 0;
            this.lb_timehen.Text = "Thời gian hẹn khám:";
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.AutoSize = true;
            this.lb_ghichu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_ghichu.Location = new System.Drawing.Point(392, 143);
            this.lb_ghichu.Name = "lb_ghichu";
            this.lb_ghichu.Size = new System.Drawing.Size(70, 18);
            this.lb_ghichu.TabIndex = 0;
            this.lb_ghichu.Text = "Ghi chú:";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_sdt.Location = new System.Drawing.Point(392, 68);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(147, 18);
            this.lb_sdt.TabIndex = 0;
            this.lb_sdt.Text = "Số điện thoại (+84):";
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.AutoSize = true;
            this.lb_Hoten.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Hoten.Location = new System.Drawing.Point(23, 68);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(61, 18);
            this.lb_Hoten.TabIndex = 0;
            this.lb_Hoten.Text = "Họ Tên:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_dangky);
            this.panel2.Location = new System.Drawing.Point(14, 287);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 243);
            this.panel2.TabIndex = 3;
            // 
            // dgv_dangky
            // 
            this.dgv_dangky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dangky.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_dangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dangky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dangky.Location = new System.Drawing.Point(0, 0);
            this.dgv_dangky.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_dangky.Name = "dgv_dangky";
            this.dgv_dangky.RowHeadersWidth = 51;
            this.dgv_dangky.RowTemplate.Height = 25;
            this.dgv_dangky.Size = new System.Drawing.Size(811, 243);
            this.dgv_dangky.TabIndex = 0;
            this.dgv_dangky.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dangky_CellClick);
            this.dgv_dangky.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dangky_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txt_searchdk);
            this.panel3.Controls.Add(this.lb_find);
            this.panel3.Controls.Add(this.btn_repair);
            this.panel3.Controls.Add(this.btn_remove);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Location = new System.Drawing.Point(14, 537);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(811, 60);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txt_searchdk
            // 
            this.txt_searchdk.Location = new System.Drawing.Point(570, 16);
            this.txt_searchdk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_searchdk.Name = "txt_searchdk";
            this.txt_searchdk.Size = new System.Drawing.Size(231, 27);
            this.txt_searchdk.TabIndex = 3;
            this.txt_searchdk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_find
            // 
            this.lb_find.AutoSize = true;
            this.lb_find.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_find.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_find.Location = new System.Drawing.Point(447, 20);
            this.lb_find.Name = "lb_find";
            this.lb_find.Size = new System.Drawing.Size(78, 20);
            this.lb_find.TabIndex = 1;
            this.lb_find.Text = "Tìm kiếm:";
            // 
            // btn_repair
            // 
            this.btn_repair.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_repair.FlatAppearance.BorderSize = 0;
            this.btn_repair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_repair.ForeColor = System.Drawing.Color.White;
            this.btn_repair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_repair.ImageIndex = 6;
            this.btn_repair.ImageList = this.imlbtn;
            this.btn_repair.Location = new System.Drawing.Point(268, 0);
            this.btn_repair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_repair.Name = "btn_repair";
            this.btn_repair.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btn_repair.Size = new System.Drawing.Size(173, 60);
            this.btn_repair.TabIndex = 2;
            this.btn_repair.Text = "  Đổi thời gian hẹn";
            this.btn_repair.UseVisualStyleBackColor = false;
            this.btn_repair.Click += new System.EventHandler(this.btn_repair_Click);
            // 
            // imlbtn
            // 
            this.imlbtn.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlbtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlbtn.ImageStream")));
            this.imlbtn.TransparentColor = System.Drawing.Color.Transparent;
            this.imlbtn.Images.SetKeyName(0, "magnifying.png");
            this.imlbtn.Images.SetKeyName(1, "verified account.ico");
            this.imlbtn.Images.SetKeyName(2, "User (1).ico");
            this.imlbtn.Images.SetKeyName(3, "User (2).ico");
            this.imlbtn.Images.SetKeyName(4, "cancel.png");
            this.imlbtn.Images.SetKeyName(5, "cancel (1).png");
            this.imlbtn.Images.SetKeyName(6, "edit.png");
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Firebrick;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.ImageIndex = 5;
            this.btn_remove.ImageList = this.imlbtn;
            this.btn_remove.Location = new System.Drawing.Point(137, 1);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btn_remove.Size = new System.Drawing.Size(119, 60);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "      Hủy bỏ";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.ImageIndex = 1;
            this.btn_add.ImageList = this.imlbtn;
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btn_add.Size = new System.Drawing.Size(125, 60);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "        Đăng ký";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(790, 16);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(35, 36);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(224, 16);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 49);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ KHÁM BỆNH";
            // 
            // time_lab
            // 
            this.time_lab.Tick += new System.EventHandler(this.time_lab_Tick);
            // 
            // DKkhambenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 613);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DKkhambenh";
            this.Text = "DKkhambenh";
            this.Load += new System.EventHandler(this.DKkhambenh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dangky)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date_henkham;
        private System.Windows.Forms.DateTimePicker date_dangky;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label lb_timedk;
        private System.Windows.Forms.Label lb_timehen;
        private System.Windows.Forms.Label lb_ghichu;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_Hoten;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_dangky;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_searchdk;
        private System.Windows.Forms.Label lb_find;
        private System.Windows.Forms.Button btn_repair;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_madk;
        private System.Windows.Forms.Label lb_madk;
        private System.Windows.Forms.ImageList imlbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_buoihen;
        private System.Windows.Forms.ComboBox cbb_buoihenkham;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_hour;
        private System.Windows.Forms.Timer time_lab;
    }
}