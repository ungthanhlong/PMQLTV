using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class PhieuMuonDAO
    {
        private static PhieuMuonDAO instance;

        public static PhieuMuonDAO Instance
        {
            get { if (instance == null)instance = new PhieuMuonDAO(); return PhieuMuonDAO.instance; }
            private set { PhieuMuonDAO.instance = value; }
        }
        public List<DSPMS> GetListDS()
        {
            List<DSPMS> listDS = new List<DSPMS>();

            string query = "SELECT ID,TenSach,SoLuong FROM dbo.ThuVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DSPMS DS = new DSPMS(item);
                listDS.Add(DS);
            }

            return listDS;
        }
        public List<Temp> GetListPM()
        {
            List<Temp> listPM = new List<Temp>();

            string query = "SELECT IDSach,TenSach,Soluong FROM dbo.Temp";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Temp PM = new Temp(item);
                listPM.Add(PM);
            }
            return listPM;
        }
        public List<Bill> GetListBill()
        {
            List<Bill> listBill = new List<Bill>();

            string query = "INSERT INTO dbo.Bill(IDBill,IDDocGia,IDSach,TenSach,SoLuong) SELECT ID,IDDocGia,IDSach,TenSach,SoLuong FROM dbo.Temp";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Bill Bill = new Bill(item);
                listBill.Add(Bill);
            }
            return listBill;
        }
        public bool T_InsertPM(int id, string tensach, int soluong)
        {
            string query = "EXEC dbo.ThemSach "+id+","+soluong+",N'"+tensach+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool T_UpdateDS(int id)
        {
            string query = "EXEC dbo.UpdateDS " + id + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool B_UpdateBill(int id)
        {
            string query = "EXEC dbo.UpdateTemp " + id + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool B_DeleteBill(int id)
        {
            string query = "DELETE dbo.Temp WHERE IDSach = "+id+"";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool B_UpdateDS(int id)
        {
            string query = "EXEC B_UpdateDS "+id+"";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool OK_UpdateTemp(int idbill, int iddg)
        {
            string query = "UPDATE Temp SET ID = "+idbill+",IDDocGia="+iddg+"";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool OK_DeleteTemp()
        {
            string query = "DELETE dbo.Temp";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<DSPMS> SearchDS(string name)
        {
            List<DSPMS> listDS = new List<DSPMS>();
            string query = string.Format("SELECT DISTINCT ID,TenSach,SoLuong FROM dbo.ThuVien WHERE dbo.fuConvertToUnsign1(TenSach) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DSPMS DS = new DSPMS(item);
                listDS.Add(DS);
            }
            return listDS;
        }
    }
}
