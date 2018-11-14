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
    public partial class UCNV : UserControl
    {
        private NhanVienBUS NVBUS = new NhanVienBUS();
        BindingSource NVList = new BindingSource();
        public UCNV()
        {
            InitializeComponent();
            Load();
            AddNVBinding();
            
        }
        public void Load()
        {
            dtgvNV.DataSource = NVList;
            List<NhanVien> list = NVBUS.GetListNV();
            NVList.DataSource = list;
            //AddNVBinding();
        }
        void AddNVBinding()
        {
            txtMNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtHTNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtNSNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            txtGTNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txtSDTNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtDCNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtCMNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            
        }

        private void btnTNV_Click(object sender, EventArgs e)
        {
            string hoten = txtHTNV.Text;
            string gioitinh = txtGTNV.Text;
            string diachi = txtDCNV.Text;
            string sdt = txtSDTNV.Text;
            string ngaysinh = txtNSNV.Text;
            int cmnd = Convert.ToInt32(txtCMNV.Text);
            int id = Convert.ToInt32(txtMNV.Text);
            if(NVBUS.InsertNV(hoten,ngaysinh,gioitinh,diachi,sdt,cmnd,id))
            {
                MessageBox.Show("Thêm thành công");
                Load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên(Có thể do trùng Mã Nhân Viên)");
            }
        }

        private void btnXNV_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMNV.Text);
            if (NVBUS.DeleteNV(id))
            {
                MessageBox.Show("Xóa thành công");
                Load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa nhân viên");
            }
        }

        private void btnSNV_Click(object sender, EventArgs e)
        {
            string hoten = txtHTNV.Text;
            string gioitinh = txtGTNV.Text;
            string diachi = txtDCNV.Text;
            string sdt = txtSDTNV.Text;
            string ngaysinh = txtNSNV.Text;
            int id = Convert.ToInt32(txtMNV.Text);
            int cmnd = Convert.ToInt32(txtCMNV.Text);
            if (NVBUS.UpdateNV(id, hoten, ngaysinh, gioitinh, diachi, sdt,cmnd))
            {
                MessageBox.Show("Sửa thành công");
                Load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nhân viên");
            }
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            NVList.DataSource = NVBUS.SearchNhanVien(txtSearchNV.Text);
        }
        public void Clear()
        {
            txtMNV.Clear();
            txtHTNV.Clear();
            txtCMNV.Clear();
            txtGTNV.Clear();
            txtSDTNV.Clear();
            txtDCNV.Clear();
            txtSearchNV.Clear();
        }

        private void btnRFNV_Click(object sender, EventArgs e)
        {
            Load();
            Clear();
        }
    }
}
