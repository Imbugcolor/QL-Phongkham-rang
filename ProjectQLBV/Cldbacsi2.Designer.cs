
namespace ProjectQLBV
{
    partial class Cldbacsi2
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
            this.btnEsc2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEsc2
            // 
            this.btnEsc2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsc2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEsc2.Location = new System.Drawing.Point(678, 21);
            this.btnEsc2.Name = "btnEsc2";
            this.btnEsc2.Size = new System.Drawing.Size(32, 25);
            this.btnEsc2.TabIndex = 2;
            this.btnEsc2.Text = "Esc";
            this.btnEsc2.UseVisualStyleBackColor = true;
            this.btnEsc2.Click += new System.EventHandler(this.btnEsc2_Click);
            // 
            // Cldbacsi2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 460);
            this.Controls.Add(this.btnEsc2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cldbacsi2";
            this.Text = "Cldbacsi2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEsc2;
    }
}