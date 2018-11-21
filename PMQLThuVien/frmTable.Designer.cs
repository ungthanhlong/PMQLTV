namespace PMQLThuVien
{
    partial class frmTable
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCD = new System.Windows.Forms.Button();
            this.btnPMS = new System.Windows.Forms.Button();
            this.btnTTDG = new System.Windows.Forms.Button();
            this.btnTTNV = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(122, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 474);
            this.panel2.TabIndex = 22;
            // 
            // btnCD
            // 
            this.btnCD.Location = new System.Drawing.Point(1, 185);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(121, 99);
            this.btnCD.TabIndex = 21;
            this.btnCD.Text = "Thư Viện";
            this.btnCD.UseVisualStyleBackColor = true;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // btnPMS
            // 
            this.btnPMS.Location = new System.Drawing.Point(1, 281);
            this.btnPMS.Name = "btnPMS";
            this.btnPMS.Size = new System.Drawing.Size(121, 99);
            this.btnPMS.TabIndex = 19;
            this.btnPMS.Text = "Phiếu Mượn Sách";
            this.btnPMS.UseVisualStyleBackColor = true;
            this.btnPMS.Click += new System.EventHandler(this.btnPMS_Click);
            // 
            // btnTTDG
            // 
            this.btnTTDG.Location = new System.Drawing.Point(1, 94);
            this.btnTTDG.Name = "btnTTDG";
            this.btnTTDG.Size = new System.Drawing.Size(121, 99);
            this.btnTTDG.TabIndex = 18;
            this.btnTTDG.Text = "Thông Tin Độc Giả";
            this.btnTTDG.UseVisualStyleBackColor = true;
            this.btnTTDG.Click += new System.EventHandler(this.btnTTDG_Click);
            // 
            // btnTTNV
            // 
            this.btnTTNV.Location = new System.Drawing.Point(1, 0);
            this.btnTTNV.Name = "btnTTNV";
            this.btnTTNV.Size = new System.Drawing.Size(121, 99);
            this.btnTTNV.TabIndex = 17;
            this.btnTTNV.Text = "Thông Tin Nhân Viên";
            this.btnTTNV.UseVisualStyleBackColor = true;
            this.btnTTNV.Click += new System.EventHandler(this.btnTTNV_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 99);
            this.button2.TabIndex = 24;
            this.button2.Text = "Danh Sách Mượn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 477);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPMS);
            this.Controls.Add(this.btnCD);
            this.Controls.Add(this.btnTTDG);
            this.Controls.Add(this.btnTTNV);
            this.Name = "frmTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.Button btnPMS;
        private System.Windows.Forms.Button btnTTDG;
        private System.Windows.Forms.Button btnTTNV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}