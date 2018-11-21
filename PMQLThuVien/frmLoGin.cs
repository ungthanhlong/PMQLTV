using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace PMQLThuVien
{
    public partial class frmLoGin : Form
    {
        private LoGinBUS login = new LoGinBUS();
        public frmLoGin()
        {
            InitializeComponent();
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Thong tin khong đủ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (login.Login1(user, pass) == true)
                {
                    frmTable f = new frmTable();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    DialogResult result = MessageBox.Show("User or pass khong đúng", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                        Application.Exit();
                    else
                    {
                        txtUser.Clear();
                        txtPass.Clear();
                        txtUser.Focus();
                    }
                }
            }
        }
    }
}
