using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class PhieuMuonBUS
    {
        public List<DSPMS> GetListDS()
        {
            return new PhieuMuonDAO().GetListDS();
        }
        public List<Temp> GetListPM()
        {
            return new PhieuMuonDAO().GetListPM();
        }
        public bool T_InsertPM(int id, string tensach, int soluong)
        {
            return new PhieuMuonDAO().T_InsertPM(id, tensach, soluong);
        }
        public List<DSPMS> SearchDS(string name)
        {
            return new PhieuMuonDAO().SearchDS(name);
        }
        public bool T_UpdateDS(int id)
        {
            return new PhieuMuonDAO().T_UpdateDS(id);
        }
        public bool B_UpdateBill(int id)
        {
            return new PhieuMuonDAO().B_UpdateBill(id);
        }
        public bool B_DeleteBill(int id)
        {
            return new PhieuMuonDAO().B_DeleteBill(id);
        }
        public bool B_UpdateDS(int id)
        {
            return new PhieuMuonDAO().B_UpdateDS(id);
        }
        public bool OK_UpdateTemp(int idbill, int iddg)
        {
            return new PhieuMuonDAO().OK_UpdateTemp(idbill, iddg);
        }
        public List<Bill> GetListBill()
        {
            return new PhieuMuonDAO().GetListBill();
        }
        public bool OK_DeleteTemp()
        {
            return new PhieuMuonDAO().OK_DeleteTemp();
        }
    }
}
