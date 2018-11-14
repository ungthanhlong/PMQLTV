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
    public partial class UCTV : UserControl
    {
        private ThuVienBUS TVBUS = new ThuVienBUS();
        BindingSource TVList = new BindingSource();
        public UCTV()
        {
            InitializeComponent();
            Load();
            AddNVBinding();
        }
        public void Load()
        {
            dtgvTV.DataSource = TVList;
            List<ThuVien> list = TVBUS.GetListTV();
            TVList.DataSource = list;
        }
        void AddNVBinding()
        {
            txtMS.DataBindings.Add(new Binding("Text", dtgvTV.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTS.DataBindings.Add(new Binding("Text", dtgvTV.DataSource, "TenSach", true, DataSourceUpdateMode.Never));
            txtTTG.DataBindings.Add(new Binding("Text", dtgvTV.DataSource, "TenTacGia", true, DataSourceUpdateMode.Never));
            txtNXB.DataBindings.Add(new Binding("Text", dtgvTV.DataSource, "NXB", true, DataSourceUpdateMode.Never));
            txtSL.DataBindings.Add(new Binding("Text", dtgvTV.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtVT.DataBindings.Add(new Binding("Text", dtgvTV.DataSource, "ViTri", true, DataSourceUpdateMode.Never));
        }

        private void btnTTV_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMS.Text);
            string tensach = txtTS.Text;
            string tentacgia = txtTTG.Text;
            string nxb = txtNXB.Text;
            string vitri = txtVT.Text;
            int soluong = Convert.ToInt32(txtSL.Text);
            if (TVBUS.InsertSach(id, tensach, tentacgia, nxb) && TVBUS.InsertViTri(vitri, soluong, id))
            {
                MessageBox.Show("Thêm thành công");
                Load();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnXTV_Click(object sender, EventArgs e)
        {
            int id = (int)dtgvTV.SelectedCells[0].OwningRow.Cells["ID"].Value;
            if (TVBUS.DeleteVitri(id) && TVBUS.DeleteSach(id))
            {
                MessageBox.Show("Xóa Thành Công");
                Load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa sách");
            }
        }

        private void btnSTV_Click(object sender, EventArgs e)
        {
            string tensach = txtTS.Text;
            string tentacgia = txtTTG.Text;
            string nxb = txtNXB.Text;
            string vitri = txtVT.Text;
            int soluong = Convert.ToInt32( txtSL.Text);
            int id = (int)dtgvTV.SelectedCells[0].OwningRow.Cells["ID"].Value;
            if (TVBUS.UpdateSach(id,tensach,tentacgia,nxb))
            {
                if (TVBUS.UpdateViTri(vitri, soluong, id))
                {
                    MessageBox.Show("Sửa Thành Công");
                    Load();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa nhân viên");
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nhân viên");
            }
        }

        private void btnTKTV_Click(object sender, EventArgs e)
        {
            TVList.DataSource = TVBUS.SearchThuVien(txtTK.Text);
        }
    }
}
