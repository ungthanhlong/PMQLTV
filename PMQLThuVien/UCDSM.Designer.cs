namespace PMQLThuVien
{
    partial class UCDSM
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
            this.dtgvDS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnTS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMDG = new System.Windows.Forms.TextBox();
            this.txtTDG = new System.Windows.Forms.TextBox();
            this.txtMB = new System.Windows.Forms.TextBox();
            this.txtNM = new System.Windows.Forms.TextBox();
            this.LVDSM = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXSM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDS
            // 
            this.dtgvDS.AllowUserToAddRows = false;
            this.dtgvDS.AllowUserToDeleteRows = false;
            this.dtgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dtgvDS.Location = new System.Drawing.Point(50, 66);
            this.dtgvDS.Name = "dtgvDS";
            this.dtgvDS.ReadOnly = true;
            this.dtgvDS.Size = new System.Drawing.Size(388, 362);
            this.dtgvDS.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "iddocgia";
            this.Column1.HeaderText = "Mã Độc Giả";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tendocgia";
            this.Column3.HeaderText = "Tên Độc Giả";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "idbill";
            this.Column2.HeaderText = "Mã Bill";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngaymuon";
            this.Column4.HeaderText = "Ngày Mượn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(140, 15);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(83, 32);
            this.btnTK.TabIndex = 1;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(256, 15);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(433, 32);
            this.txtTK.TabIndex = 2;
            // 
            // btnTS
            // 
            this.btnTS.Location = new System.Drawing.Point(732, 438);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(99, 31);
            this.btnTS.TabIndex = 3;
            this.btnTS.Text = "Trả Sách";
            this.btnTS.UseVisualStyleBackColor = true;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Độc Giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Độc Giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Bill:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày Mượn:";
            // 
            // txtMDG
            // 
            this.txtMDG.Location = new System.Drawing.Point(624, 104);
            this.txtMDG.Multiline = true;
            this.txtMDG.Name = "txtMDG";
            this.txtMDG.Size = new System.Drawing.Size(220, 21);
            this.txtMDG.TabIndex = 8;
            // 
            // txtTDG
            // 
            this.txtTDG.Location = new System.Drawing.Point(624, 132);
            this.txtTDG.Multiline = true;
            this.txtTDG.Name = "txtTDG";
            this.txtTDG.Size = new System.Drawing.Size(220, 21);
            this.txtTDG.TabIndex = 9;
            // 
            // txtMB
            // 
            this.txtMB.Location = new System.Drawing.Point(624, 163);
            this.txtMB.Multiline = true;
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(220, 21);
            this.txtMB.TabIndex = 10;
            // 
            // txtNM
            // 
            this.txtNM.Location = new System.Drawing.Point(624, 197);
            this.txtNM.Multiline = true;
            this.txtNM.Name = "txtNM";
            this.txtNM.Size = new System.Drawing.Size(220, 21);
            this.txtNM.TabIndex = 11;
            // 
            // LVDSM
            // 
            this.LVDSM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LVDSM.Location = new System.Drawing.Point(515, 267);
            this.LVDSM.Name = "LVDSM";
            this.LVDSM.Size = new System.Drawing.Size(315, 161);
            this.LVDSM.TabIndex = 12;
            this.LVDSM.UseCompatibleStateImageBehavior = false;
            this.LVDSM.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sách";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sách";
            this.columnHeader2.Width = 178;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            // 
            // btnXSM
            // 
            this.btnXSM.Location = new System.Drawing.Point(515, 229);
            this.btnXSM.Name = "btnXSM";
            this.btnXSM.Size = new System.Drawing.Size(104, 32);
            this.btnXSM.TabIndex = 13;
            this.btnXSM.Text = "Xem Sách Mượn";
            this.btnXSM.UseVisualStyleBackColor = true;
            this.btnXSM.Click += new System.EventHandler(this.btnXSM_Click);
            // 
            // UCDSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXSM);
            this.Controls.Add(this.LVDSM);
            this.Controls.Add(this.txtNM);
            this.Controls.Add(this.txtMB);
            this.Controls.Add(this.txtTDG);
            this.Controls.Add(this.txtMDG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTS);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtgvDS);
            this.Name = "UCDSM";
            this.Size = new System.Drawing.Size(865, 486);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDS;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMDG;
        private System.Windows.Forms.TextBox txtTDG;
        private System.Windows.Forms.TextBox txtMB;
        private System.Windows.Forms.TextBox txtNM;
        private System.Windows.Forms.ListView LVDSM;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnXSM;
    }
}
