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
using System.Data.SqlClient;

namespace PMQLThuVien
{
    public partial class UCPMS : UserControl
    {
        private PhieuMuonBUS PMBUS = new PhieuMuonBUS();
        public UCPMS()
        {
            InitializeComponent();
            LoadDS();
            LoadBill();
        }
        public void LoadDS()
        {
            List<DSPMS> list = PMBUS.GetListDS();
            dtgvDS.DataSource = list;
        }
        public void LoadBill()
        {
            List<Temp> listPM = PMBUS.GetListPM();
            dtgvPM.DataSource = listPM;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

           
          
                int id = (int)dtgvDS.SelectedCells[0].OwningRow.Cells["Column1"].Value;
                string tensach = dtgvDS.SelectedCells[0].OwningRow.Cells["Column2"].Value.ToString();
                int soluong = 1;
                int thu = (int)dtgvDS.SelectedCells[0].OwningRow.Cells["Column3"].Value;
                if (thu < 1)
                {
                    MessageBox.Show("Hết Sách");
                }
                else
                {

                    if (PMBUS.T_InsertPM(id, tensach, soluong))
                    {
                        LoadBill();
                        PMBUS.T_UpdateDS(id);
                        LoadDS();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm sách");
                    }
                }
            
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dtgvPM.SelectedCells[0].OwningRow.Cells["Column4"].Value;
                string tensach = dtgvPM.SelectedCells[0].OwningRow.Cells["Column5"].Value.ToString();
                int soluong = 1;
                int thu = (int)dtgvPM.SelectedCells[0].OwningRow.Cells["Column6"].Value;
                if (thu < 2)
                {
                    PMBUS.B_DeleteBill(id);
                    LoadBill();
                }
                else
                {

                    if (PMBUS.B_UpdateDS(id))
                    {

                        LoadDS();
                        PMBUS.B_UpdateBill(id);
                        LoadBill();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm sách");
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
                
            
        }

        private void btnTKMS_Click(object sender, EventArgs e)
        {
            dtgvDS.DataSource = PMBUS.SearchDS(txtSearchDS.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int idbill = Convert.ToInt32(txtMB.Text);
            int iddg = Convert.ToInt32(txtMDG.Text);
            if (PMBUS.OK_UpdateTemp(idbill, iddg))
            {
                PMBUS.GetListBill();
                MessageBox.Show("Thành công");
                PMBUS.OK_DeleteTemp();
                LoadBill();
                txtMB.Clear();
                txtMDG.Clear();
            }
            else
            {
                MessageBox.Show("Thất Bại");
                PMBUS.OK_DeleteTemp();
            }

        }
    }
}
            