namespace PMQLThuVien
{
    partial class UCPMS
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvPM = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMB = new System.Windows.Forms.TextBox();
            this.txtMDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBot = new System.Windows.Forms.Button();
            this.btnTKMS = new System.Windows.Forms.Button();
            this.txtSearchDS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPM)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDS
            // 
            this.dtgvDS.AllowUserToAddRows = false;
            this.dtgvDS.AllowUserToDeleteRows = false;
            this.dtgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvDS.Location = new System.Drawing.Point(23, 66);
            this.dtgvDS.Name = "dtgvDS";
            this.dtgvDS.ReadOnly = true;
            this.dtgvDS.Size = new System.Drawing.Size(328, 406);
            this.dtgvDS.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Mã Sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSach";
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // dtgvPM
            // 
            this.dtgvPM.AllowUserToAddRows = false;
            this.dtgvPM.AllowUserToDeleteRows = false;
            this.dtgvPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvPM.Location = new System.Drawing.Point(496, 166);
            this.dtgvPM.Name = "dtgvPM";
            this.dtgvPM.ReadOnly = true;
            this.dtgvPM.Size = new System.Drawing.Size(326, 244);
            this.dtgvPM.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "idsach";
            this.Column4.HeaderText = "Mã Sách";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tensach";
            this.Column5.HeaderText = "Tên Sách";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "soluong";
            this.Column6.HeaderText = "Số Lượng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Bill:";
            // 
            // txtMB
            // 
            this.txtMB.Location = new System.Drawing.Point(592, 44);
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(225, 20);
            this.txtMB.TabIndex = 3;
            // 
            // txtMDG
            // 
            this.txtMDG.Location = new System.Drawing.Point(592, 94);
            this.txtMDG.Name = "txtMDG";
            this.txtMDG.Size = new System.Drawing.Size(225, 20);
            this.txtMDG.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Độc Giả:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(737, 427);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 45);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(387, 226);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 32);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "-->";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBot
            // 
            this.btnBot.Location = new System.Drawing.Point(387, 295);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(69, 32);
            this.btnBot.TabIndex = 10;
            this.btnBot.Text = "<--";
            this.btnBot.UseVisualStyleBackColor = true;
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnTKMS
            // 
            this.btnTKMS.Location = new System.Drawing.Point(23, 17);
            this.btnTKMS.Name = "btnTKMS";
            this.btnTKMS.Size = new System.Drawing.Size(69, 32);
            this.btnTKMS.TabIndex = 11;
            this.btnTKMS.Text = "Tìm Kiếm";
            this.btnTKMS.UseVisualStyleBackColor = true;
            this.btnTKMS.Click += new System.EventHandler(this.btnTKMS_Click);
            // 
            // txtSearchDS
            // 
            this.txtSearchDS.Location = new System.Drawing.Point(107, 17);
            this.txtSearchDS.Multiline = true;
            this.txtSearchDS.Name = "txtSearchDS";
            this.txtSearchDS.Size = new System.Drawing.Size(244, 32);
            this.txtSearchDS.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sách Mượn:";
            // 
            // UCPMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchDS);
            this.Controls.Add(this.btnTKMS);
            this.Controls.Add(this.btnBot);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMDG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvPM);
            this.Controls.Add(this.dtgvDS);
            this.Name = "UCPMS";
            this.Size = new System.Drawing.Size(865, 486);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDS;
        private System.Windows.Forms.DataGridView dtgvPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMB;
        private System.Windows.Forms.TextBox txtMDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Button btnTKMS;
        private System.Windows.Forms.TextBox txtSearchDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
