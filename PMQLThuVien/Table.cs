using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMQLThuVien
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new UCTV());
        }

        private void btnTTNV_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new UCNV());
        }

        private void btnTTDG_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new UCDG());
        }
    }
}
