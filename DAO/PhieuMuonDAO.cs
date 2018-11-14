using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;

namespace DAO
{
    public class PhieuMuonDAO
    {
        public List<PhieuMuon> GetListPM()
        {
            List<PhieuMuon> listPM = new List<PhieuMuon>();

            string query = "SELECT DISTINCT ID,TenSach,SoLuong  FROM dbo.ThuVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuon PM = new PhieuMuon(item);
                listPM.Add(PM);
            }

            return listPM;
        }
        public List<PhieuMuon> SearchPhieuMuon(string name)
        {
            List<PhieuMuon> listPM = new List<PhieuMuon>();
            string query = string.Format("SELECT DISTINCT ID,TenSach,SoLuong FROM dbo.ThuVien WHERE dbo.fuConvertToUnsign1(TenSach) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuMuon PM = new PhieuMuon(item);
                listPM.Add(PM);
            }
            return listPM;
        }
    }
}
