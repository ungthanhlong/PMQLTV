using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;

namespace DAO
{
    public class DSMDAO
    {
        private static DSMDAO instance;

        public static DSMDAO Instance
        {
            get { if (instance == null)instance = new DSMDAO(); return DSMDAO.instance; }
            private set { DSMDAO.instance = value; }
        }
        public List<DSM> GetListDS()
        {
            List<DSM> listDS = new List<DSM>();

            string query = "SELECT * FROM dbo.DSM";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DSM DS = new DSM(item);
                listDS.Add(DS);
            }

            return listDS;
        }
        public List<XemMuonSach> GetListXS()
        {
            List<XemMuonSach> listXS = new List<XemMuonSach>();

            string query = "SELECT IDSach,TenSach,SoLuong  FROM dbo.Bill ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                XemMuonSach XS = new XemMuonSach(item);
                listXS.Add(XS);
            }

            return listXS;
        }
        public List<DSM> SearchDSM(string name)
        {
            List<DSM> listDSM = new List<DSM>();
            string query = string.Format("SELECT * FROM dbo.DSM WHERE dbo.fuConvertToUnsign1(HoTen) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DSM DSM = new DSM(item);
                listDSM.Add(DSM);
            }
            return listDSM;
        }
        public List<XemMuonSach> SearchXS(string name)
        {
            List<XemMuonSach> listXS = new List<XemMuonSach>();
            string query = string.Format("SELECT * FROM dbo.Bill WHERE dbo.fuConvertToUnsign1(IDBill) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                XemMuonSach XS = new XemMuonSach(item);
                listXS.Add(XS);
            }
            return listXS;
        }
        public bool TraSach(int id)
        {
            string query = "DELETE dbo.Bill WHERE IDBill= "+id+"";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
