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
    public partial class UCDG : UserControl
    {
        private DocGiaBUS DGBUS = new DocGiaBUS();
        BindingSource DGList = new BindingSource();
        public UCDG()
        {
            InitializeComponent();
            Load();
            AddNVBinding();
        }
        public void Load()
        {
            dtgvDG.DataSource = DGList;
            List<DocGia> list = DGBUS.GetListDG();
            DGList.DataSource = list;
            //AddNVBinding();
        }
        void AddNVBinding()
        {
            txtMDG.DataBindings.Add(new Binding("Text", dtgvDG.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtHTDG.DataBindings.Add(new Binding("Text", dtgvDG.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtNSDG.DataBindings.Add(new Binding("Text", dtgvDG.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            txtGTDG.DataBindings.Add(new Binding("Text", dtgvDG.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txtSDTDG.DataBindings.Add(new Binding("Text", dtgvDG.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtDCDG.DataBindings.Add(new Binding("Text", dtgvDG.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtCMDG.DataBindings.Add(new Binding("Text", dtgvDG.DataSource, "CMND", true, DataSourceUpdateMode.Never));
        }

        private void btnTDG_Click(object sender, EventArgs e)
        {
            string hoten = txtHTDG.Text;
            string gioitinh = txtGTDG.Text;
            string diachi = txtDCDG.Text;
            string sdt = txtSDTDG.Text;
            string ngaysinh = txtNSDG.Text;
            int cmnd = Convert.ToInt32(txtCMDG.Text);
            int id = Convert.ToInt32(txtMDG.Text);
            if (DGBUS.InsertDG(hoten, ngaysinh, gioitinh, diachi, sdt, cmnd, id))
            {
                MessageBox.Show("Thêm thành công");
                Load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm độc giả(Có thể do trùng Mã Độc Giả)");
            }
        }

        private void btnXDG_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMDG.Text);
            if (DGBUS.DeleteDG(id))
            {
                MessageBox.Show("Xóa thành công");
                Load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa độc giả");
            }
        }

        private void btnSDG_Click(object sender, EventArgs e)
        {
            string hoten = txtHTDG.Text;
            string gioitinh = txtGTDG.Text;
            string diachi = txtDCDG.Text;
            string sdt = txtSDTDG.Text;
            string ngaysinh = txtNSDG.Text;
            int id = Convert.ToInt32(txtMDG.Text);
            int cmnd = Convert.ToInt32(txtCMDG.Text);
            if (DGBUS.UpdateDG(id, hoten, ngaysinh, gioitinh, diachi, sdt, cmnd))
            {
                MessageBox.Show("Sửa thành công");
                Load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa độc giả");
            }
        }
        public void Clear()
        {
            txtMDG.Clear();
            txtHTDG.Clear();
            txtNSDG.Clear();
            txtGTDG.Clear();
            txtSDTDG.Clear();
            txtDCDG.Clear();
            txtSearchDG.Clear();
        }

        private void btnSearchDG_Click(object sender, EventArgs e)
        {
            DGList.DataSource = DGBUS.SearchDocGia(txtSearchDG.Text);
        }

        private void btnRFDG_Click(object sender, EventArgs e)
        {
            Load();
            Clear();
        }
    }
}
