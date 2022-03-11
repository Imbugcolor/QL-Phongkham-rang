
namespace ProjectQLBV
{
    partial class Thongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongke));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nxtbtn = new System.Windows.Forms.Button();
            this.prevbtn = new System.Windows.Forms.Button();
            this.date_thongke = new System.Windows.Forms.DateTimePicker();
            this.txtThongke = new System.Windows.Forms.Label();
            this.lbdatecheck = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nxtbtn);
            this.panel1.Controls.Add(this.prevbtn);
            this.panel1.Controls.Add(this.date_thongke);
            this.panel1.Controls.Add(this.txtThongke);
            this.panel1.Controls.Add(this.lbdatecheck);
            this.panel1.Location = new System.Drawing.Point(12, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 92);
            this.panel1.TabIndex = 2;
            // 
            // nxtbtn
            // 
            this.nxtbtn.Location = new System.Drawing.Point(504, 31);
            this.nxtbtn.Name = "nxtbtn";
            this.nxtbtn.Size = new System.Drawing.Size(62, 40);
            this.nxtbtn.TabIndex = 29;
            this.nxtbtn.Text = "Tiếp >>";
            this.nxtbtn.UseVisualStyleBackColor = true;
            this.nxtbtn.Click += new System.EventHandler(this.nxtbtn_Click);
            // 
            // prevbtn
            // 
            this.prevbtn.Location = new System.Drawing.Point(286, 31);
            this.prevbtn.Name = "prevbtn";
            this.prevbtn.Size = new System.Drawing.Size(66, 40);
            this.prevbtn.TabIndex = 28;
            this.prevbtn.Text = "<< Trước";
            this.prevbtn.UseVisualStyleBackColor = true;
            this.prevbtn.Click += new System.EventHandler(this.prevbtn_Click);
            // 
            // date_thongke
            // 
            this.date_thongke.Location = new System.Drawing.Point(358, 38);
            this.date_thongke.Name = "date_thongke";
            this.date_thongke.Size = new System.Drawing.Size(140, 23);
            this.date_thongke.TabIndex = 27;
            this.date_thongke.ValueChanged += new System.EventHandler(this.date_thongke_ValueChanged);
            // 
            // txtThongke
            // 
            this.txtThongke.AutoSize = true;
            this.txtThongke.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtThongke.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtThongke.Location = new System.Drawing.Point(10, 12);
            this.txtThongke.Name = "txtThongke";
            this.txtThongke.Size = new System.Drawing.Size(161, 31);
            this.txtThongke.TabIndex = 16;
            this.txtThongke.Text = "THỐNG KÊ";
            // 
            // lbdatecheck
            // 
            this.lbdatecheck.AutoSize = true;
            this.lbdatecheck.Location = new System.Drawing.Point(92, 44);
            this.lbdatecheck.Name = "lbdatecheck";
            this.lbdatecheck.Size = new System.Drawing.Size(0, 15);
            this.lbdatecheck.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 283);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(763, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Thongke";
            this.Text = "Thống kê";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date_thongke;
        private System.Windows.Forms.Label txtThongke;
        private System.Windows.Forms.Label lbdatecheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button prevbtn;
        private System.Windows.Forms.Button nxtbtn;
    }
}