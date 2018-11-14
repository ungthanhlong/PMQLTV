namespace PMQLThuVien
{
    partial class UCNV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTNV = new System.Windows.Forms.Button();
            this.btnSearchNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchNV = new System.Windows.Forms.TextBox();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.txtCMNV = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXNV = new System.Windows.Forms.Button();
            this.btnSNV = new System.Windows.Forms.Button();
            this.txtDCNV = new System.Windows.Forms.TextBox();
            this.btnRFNV = new System.Windows.Forms.Button();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtHTNV = new System.Windows.Forms.TextBox();
            this.txtGTNV = new System.Windows.Forms.TextBox();
            this.txtNSNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvNV
            // 
            this.dtgvNV.AllowUserToAddRows = false;
            this.dtgvNV.AllowUserToDeleteRows = false;
            this.dtgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dtgvNV.Location = new System.Drawing.Point(3, 74);
            this.dtgvNV.Name = "dtgvNV";
            this.dtgvNV.ReadOnly = true;
            this.dtgvNV.Size = new System.Drawing.Size(406, 395);
            this.dtgvNV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "hoten";
            this.Column2.HeaderText = "Tên Nhân Viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gioitinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngaysinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "cmnd";
            this.Column7.HeaderText = "CMND";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sdt";
            this.Column5.HeaderText = "SĐT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "diachi";
            this.Column6.HeaderText = "Địa Chỉ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 500;
            // 
            // btnTNV
            // 
            this.btnTNV.Location = new System.Drawing.Point(25, 13);
            this.btnTNV.Name = "btnTNV";
            this.btnTNV.Size = new System.Drawing.Size(72, 54);
            this.btnTNV.TabIndex = 1;
            this.btnTNV.Text = "Thêm";
            this.btnTNV.UseVisualStyleBackColor = true;
            this.btnTNV.Click += new System.EventHandler(this.btnTNV_Click);
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.Location = new System.Drawing.Point(364, 35);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Size = new System.Drawing.Size(91, 32);
            this.btnSearchNV.TabIndex = 4;
            this.btnSearchNV.Text = "Tìm Kiếm";
            this.btnSearchNV.UseVisualStyleBackColor = true;
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giới Tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(431, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "SĐT:";
            // 
            // txtSearchNV
            // 
            this.txtSearchNV.Location = new System.Drawing.Point(493, 41);
            this.txtSearchNV.Multiline = true;
            this.txtSearchNV.Name = "txtSearchNV";
            this.txtSearchNV.Size = new System.Drawing.Size(277, 26);
            this.txtSearchNV.TabIndex = 11;
            // 
            // txtMNV
            // 
            this.txtMNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNV.Location = new System.Drawing.Point(677, 84);
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(148, 22);
            this.txtMNV.TabIndex = 12;
            // 
            // txtCMNV
            // 
            this.txtCMNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNV.Location = new System.Drawing.Point(677, 188);
            this.txtCMNV.Name = "txtCMNV";
            this.txtCMNV.Size = new System.Drawing.Size(148, 22);
            this.txtCMNV.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(434, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 141);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnXNV
            // 
            this.btnXNV.Location = new System.Drawing.Point(119, 13);
            this.btnXNV.Name = "btnXNV";
            this.btnXNV.Size = new System.Drawing.Size(72, 54);
            this.btnXNV.TabIndex = 18;
            this.btnXNV.Text = "Xóa";
            this.btnXNV.UseVisualStyleBackColor = true;
            this.btnXNV.Click += new System.EventHandler(this.btnXNV_Click);
            // 
            // btnSNV
            // 
            this.btnSNV.Location = new System.Drawing.Point(217, 13);
            this.btnSNV.Name = "btnSNV";
            this.btnSNV.Size = new System.Drawing.Size(72, 54);
            this.btnSNV.TabIndex = 19;
            this.btnSNV.Text = "Sửa";
            this.btnSNV.UseVisualStyleBackColor = true;
            this.btnSNV.Click += new System.EventHandler(this.btnSNV_Click);
            // 
            // txtDCNV
            // 
            this.txtDCNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDCNV.Location = new System.Drawing.Point(498, 274);
            this.txtDCNV.Multiline = true;
            this.txtDCNV.Name = "txtDCNV";
            this.txtDCNV.Size = new System.Drawing.Size(327, 149);
            this.txtDCNV.TabIndex = 20;
            // 
            // btnRFNV
            // 
            this.btnRFNV.Location = new System.Drawing.Point(752, 437);
            this.btnRFNV.Name = "btnRFNV";
            this.btnRFNV.Size = new System.Drawing.Size(100, 32);
            this.btnRFNV.TabIndex = 21;
            this.btnRFNV.Text = "Refresh";
            this.btnRFNV.UseVisualStyleBackColor = true;
            this.btnRFNV.Click += new System.EventHandler(this.btnRFNV_Click);
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNV.Location = new System.Drawing.Point(498, 248);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(327, 22);
            this.txtSDTNV.TabIndex = 22;
            // 
            // txtHTNV
            // 
            this.txtHTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHTNV.Location = new System.Drawing.Point(677, 111);
            this.txtHTNV.Name = "txtHTNV";
            this.txtHTNV.Size = new System.Drawing.Size(148, 22);
            this.txtHTNV.TabIndex = 23;
            // 
            // txtGTNV
            // 
            this.txtGTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTNV.Location = new System.Drawing.Point(677, 136);
            this.txtGTNV.Name = "txtGTNV";
            this.txtGTNV.Size = new System.Drawing.Size(148, 22);
            this.txtGTNV.TabIndex = 24;
            // 
            // txtNSNV
            // 
            this.txtNSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSNV.Location = new System.Drawing.Point(677, 162);
            this.txtNSNV.Name = "txtNSNV";
            this.txtNSNV.Size = new System.Drawing.Size(148, 22);
            this.txtNSNV.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "CMND:";
            // 
            // UCNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNSNV);
            this.Controls.Add(this.txtGTNV);
            this.Controls.Add(this.txtHTNV);
            this.Controls.Add(this.txtSDTNV);
            this.Controls.Add(this.btnRFNV);
            this.Controls.Add(this.txtDCNV);
            this.Controls.Add(this.btnSNV);
            this.Controls.Add(this.btnXNV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCMNV);
            this.Controls.Add(this.txtMNV);
            this.Controls.Add(this.txtSearchNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchNV);
            this.Controls.Add(this.btnTNV);
            this.Controls.Add(this.dtgvNV);
            this.Name = "UCNV";
            this.Size = new System.Drawing.Size(865, 486);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNV;
        private System.Windows.Forms.Button btnTNV;
        private System.Windows.Forms.Button btnSearchNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchNV;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.TextBox txtCMNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXNV;
        private System.Windows.Forms.Button btnSNV;
        private System.Windows.Forms.TextBox txtDCNV;
        private System.Windows.Forms.Button btnRFNV;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.TextBox txtHTNV;
        private System.Windows.Forms.TextBox txtGTNV;
        private System.Windows.Forms.TextBox txtNSNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
