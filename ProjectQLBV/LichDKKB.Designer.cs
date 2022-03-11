
namespace ProjectQLBV
{
    partial class LichDKKB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichDKKB));
            this.label1 = new System.Windows.Forms.Label();
            this.date_henkham = new System.Windows.Forms.DateTimePicker();
            this.cbb_buoihen = new System.Windows.Forms.ComboBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.data_show = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(249, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH HẸN KHÁM BỆNH";
            // 
            // date_henkham
            // 
            this.date_henkham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_henkham.Location = new System.Drawing.Point(249, 112);
            this.date_henkham.Name = "date_henkham";
            this.date_henkham.Size = new System.Drawing.Size(147, 27);
            this.date_henkham.TabIndex = 1;
            this.date_henkham.ValueChanged += new System.EventHandler(this.date_henkham_ValueChanged);
            // 
            // cbb_buoihen
            // 
            this.cbb_buoihen.FormattingEnabled = true;
            this.cbb_buoihen.Items.AddRange(new object[] {
            "Sáng",
            "Chiều",
            "Tối"});
            this.cbb_buoihen.Location = new System.Drawing.Point(405, 111);
            this.cbb_buoihen.Name = "cbb_buoihen";
            this.cbb_buoihen.Size = new System.Drawing.Size(119, 28);
            this.cbb_buoihen.TabIndex = 2;
            this.cbb_buoihen.SelectedIndexChanged += new System.EventHandler(this.cbb_buoihen_SelectedIndexChanged);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_prev.FlatAppearance.BorderSize = 0;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_prev.ForeColor = System.Drawing.Color.White;
            this.btn_prev.Location = new System.Drawing.Point(149, 109);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(94, 31);
            this.btn_prev.TabIndex = 3;
            this.btn_prev.Text = "<< Trước";
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(530, 109);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(94, 32);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Tiếp >>";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // data_show
            // 
            this.data_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_show.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_show.Location = new System.Drawing.Point(39, 173);
            this.data_show.Name = "data_show";
            this.data_show.RowHeadersWidth = 51;
            this.data_show.RowTemplate.Height = 29;
            this.data_show.Size = new System.Drawing.Size(733, 232);
            this.data_show.TabIndex = 4;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(749, 15);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(43, 40);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // LichDKKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 565);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.data_show);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.cbb_buoihen);
            this.Controls.Add(this.date_henkham);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LichDKKB";
            this.Text = "LichDKKB";
            ((System.ComponentModel.ISupportInitialize)(this.data_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_henkham;
        private System.Windows.Forms.ComboBox cbb_buoihen;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.DataGridView data_show;
        private System.Windows.Forms.Button btn_exit;
    }
}