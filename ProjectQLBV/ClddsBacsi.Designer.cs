
namespace ProjectQLBV
{
    partial class ClddsBacsi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClddsBacsi));
            this.btnEsc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbox_find = new System.Windows.Forms.PictureBox();
            this.txt_cldsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cldsort = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.date_cldngsinh = new System.Windows.Forms.DateTimePicker();
            this.txt_cldsdt = new System.Windows.Forms.TextBox();
            this.txt_clddiachi = new System.Windows.Forms.TextBox();
            this.txt_cldgioitinh = new System.Windows.Forms.TextBox();
            this.txt_cldtenbs = new System.Windows.Forms.TextBox();
            this.txt_cldmabs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_cldbacsi = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_find)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cldbacsi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEsc
            // 
            this.btnEsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsc.FlatAppearance.BorderSize = 0;
            this.btnEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsc.Image = ((System.Drawing.Image)(resources.GetObject("btnEsc.Image")));
            this.btnEsc.Location = new System.Drawing.Point(668, 12);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(32, 28);
            this.btnEsc.TabIndex = 1;
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(242, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH MỤC BÁC SĨ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.picbox_find);
            this.panel1.Controls.Add(this.txt_cldsearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_cldsort);
            this.panel1.Location = new System.Drawing.Point(12, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 38);
            this.panel1.TabIndex = 2;
            // 
            // picbox_find
            // 
            this.picbox_find.Image = ((System.Drawing.Image)(resources.GetObject("picbox_find.Image")));
            this.picbox_find.Location = new System.Drawing.Point(230, 12);
            this.picbox_find.Name = "picbox_find";
            this.picbox_find.Size = new System.Drawing.Size(30, 23);
            this.picbox_find.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_find.TabIndex = 4;
            this.picbox_find.TabStop = false;
            // 
            // txt_cldsearch
            // 
            this.txt_cldsearch.Location = new System.Drawing.Point(271, 12);
            this.txt_cldsearch.Name = "txt_cldsearch";
            this.txt_cldsearch.Size = new System.Drawing.Size(205, 23);
            this.txt_cldsearch.TabIndex = 1;
            this.txt_cldsearch.TextChanged += new System.EventHandler(this.txt_cldsearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(147, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm:";
            // 
            // btn_cldsort
            // 
            this.btn_cldsort.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_cldsort.FlatAppearance.BorderSize = 0;
            this.btn_cldsort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cldsort.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cldsort.ForeColor = System.Drawing.Color.White;
            this.btn_cldsort.Image = ((System.Drawing.Image)(resources.GetObject("btn_cldsort.Image")));
            this.btn_cldsort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cldsort.Location = new System.Drawing.Point(26, 0);
            this.btn_cldsort.Name = "btn_cldsort";
            this.btn_cldsort.Size = new System.Drawing.Size(93, 38);
            this.btn_cldsort.TabIndex = 0;
            this.btn_cldsort.Text = "      Sắp xếp";
            this.btn_cldsort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cldsort.UseVisualStyleBackColor = false;
            this.btn_cldsort.Click += new System.EventHandler(this.btn_cldsort_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.date_cldngsinh);
            this.panel2.Controls.Add(this.txt_cldsdt);
            this.panel2.Controls.Add(this.txt_clddiachi);
            this.panel2.Controls.Add(this.txt_cldgioitinh);
            this.panel2.Controls.Add(this.txt_cldtenbs);
            this.panel2.Controls.Add(this.txt_cldmabs);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(38, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 149);
            this.panel2.TabIndex = 1;
            // 
            // date_cldngsinh
            // 
            this.date_cldngsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_cldngsinh.Location = new System.Drawing.Point(102, 90);
            this.date_cldngsinh.Name = "date_cldngsinh";
            this.date_cldngsinh.Size = new System.Drawing.Size(157, 23);
            this.date_cldngsinh.TabIndex = 3;
            // 
            // txt_cldsdt
            // 
            this.txt_cldsdt.Location = new System.Drawing.Point(416, 90);
            this.txt_cldsdt.Name = "txt_cldsdt";
            this.txt_cldsdt.Size = new System.Drawing.Size(134, 23);
            this.txt_cldsdt.TabIndex = 6;
            // 
            // txt_clddiachi
            // 
            this.txt_clddiachi.Location = new System.Drawing.Point(363, 48);
            this.txt_clddiachi.Name = "txt_clddiachi";
            this.txt_clddiachi.Size = new System.Drawing.Size(259, 23);
            this.txt_clddiachi.TabIndex = 5;
            // 
            // txt_cldgioitinh
            // 
            this.txt_cldgioitinh.Location = new System.Drawing.Point(363, 10);
            this.txt_cldgioitinh.Name = "txt_cldgioitinh";
            this.txt_cldgioitinh.Size = new System.Drawing.Size(88, 23);
            this.txt_cldgioitinh.TabIndex = 4;
            // 
            // txt_cldtenbs
            // 
            this.txt_cldtenbs.Location = new System.Drawing.Point(102, 48);
            this.txt_cldtenbs.Name = "txt_cldtenbs";
            this.txt_cldtenbs.Size = new System.Drawing.Size(157, 23);
            this.txt_cldtenbs.TabIndex = 2;
            // 
            // txt_cldmabs
            // 
            this.txt_cldmabs.Location = new System.Drawing.Point(102, 13);
            this.txt_cldmabs.Name = "txt_cldmabs";
            this.txt_cldmabs.Size = new System.Drawing.Size(88, 23);
            this.txt_cldmabs.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(283, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(283, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số điện thoại(+84):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(283, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên bác sĩ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã bác sĩ:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgv_cldbacsi);
            this.panel3.Location = new System.Drawing.Point(39, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 203);
            this.panel3.TabIndex = 3;
            // 
            // dgv_cldbacsi
            // 
            this.dgv_cldbacsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cldbacsi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_cldbacsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cldbacsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cldbacsi.Location = new System.Drawing.Point(0, 0);
            this.dgv_cldbacsi.Name = "dgv_cldbacsi";
            this.dgv_cldbacsi.RowHeadersWidth = 51;
            this.dgv_cldbacsi.RowTemplate.Height = 25;
            this.dgv_cldbacsi.Size = new System.Drawing.Size(661, 203);
            this.dgv_cldbacsi.TabIndex = 0;
            this.dgv_cldbacsi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cldbacsi_CellClick);
            // 
            // ClddsBacsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 460);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEsc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClddsBacsi";
            this.Text = "ClddsBacsi";
            this.Load += new System.EventHandler(this.ClddsBacsi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_find)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cldbacsi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_cldsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cldsort;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cldsdt;
        private System.Windows.Forms.TextBox txt_clddiachi;
        private System.Windows.Forms.TextBox txt_cldgioitinh;
        private System.Windows.Forms.TextBox txt_cldtenbs;
        private System.Windows.Forms.TextBox txt_cldmabs;
        private System.Windows.Forms.DateTimePicker date_cldngsinh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_cldbacsi;
        private System.Windows.Forms.PictureBox picbox_find;
    }
}