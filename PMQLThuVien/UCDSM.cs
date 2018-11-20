using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace PMQLThuVien
{
    public partial class UCDSM : UserControl
    {
        private DSMBUS DSMBUS = new DSMBUS();
        BindingSource DSM = new BindingSource();
        public UCDSM()
        {
            InitializeComponent();
            Load();
            AddDSMBinding();
        }
        public void Load()
        {
            dtgvDS.DataSource = DSM;
            List<DSM> list = DSMBUS.GetListDS();
            DSM.DataSource = list;
        }
        public void LoadXS()
        {
            LVDSM.Items.Clear();
            string id = txtMB.Text; 
            List<XemMuonSach> listXS = DSMBUS.SearchXS(id);
            foreach (XemMuonSach item in listXS)
            {
                ListViewItem items = new ListViewItem(item.idsach.ToString());
                items.SubItems.Add(item.tensach);
                items.SubItems.Add(item.soluong.ToString());
                LVDSM.Items.Add(items);
            }
        }
        void AddDSMBinding()
        {
            txtMDG.DataBindings.Add(new Binding("Text", dtgvDS.DataSource, "iddocgia", true, DataSourceUpdateMode.Never));
            txtTDG.DataBindings.Add(new Binding("Text", dtgvDS.DataSource, "tendocgia", true, DataSourceUpdateMode.Never));
            txtMB.DataBindings.Add(new Binding("Text", dtgvDS.DataSource, "idbill", true, DataSourceUpdateMode.Never));
            txtNM.DataBindings.Add(new Binding("Text", dtgvDS.DataSource, "ngaymuon", true, DataSourceUpdateMode.Never));      
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            DSM.DataSource = DSMBUS.SearchDSM(txtTK.Text);
        }

        private void btnXSM_Click(object sender, EventArgs e)
        {
            
            LoadXS();
        }

        private void btnTS_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( txtMB.Text);
            if (DSMBUS.TraSach(id))
            {
                MessageBox.Show("Đã trả sách");
            }
            else
            {
                MessageBox.Show("Trả sách thất bại");
            }
        }
        
    }
}
