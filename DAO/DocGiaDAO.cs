using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;

namespace DAO
{
    public class DocGiaDAO
    {
        private static DocGiaDAO instance;
       
        public static DocGiaDAO Instance
        {
            get { if (instance == null)instance = new DocGiaDAO(); return DocGiaDAO.instance; }
            private set { DocGiaDAO.instance = value; }
        }
        public List<DocGia> GetListDG()
        {
            List<DocGia> listDG = new List<DocGia>();

            string query = "SELECT * FROM dbo.DocGia";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DocGia DG = new DocGia(item);
                listDG.Add(DG);
            }

            return listDG;
        }
        public bool InsertDG(string hoten, string ngaysinh, string gioitinh, string diachi, string sdt, int cmnd, int id)
        {
            string query = "INSERT INTO dbo.DocGia ( ID, HoTen, NgaySinh, GioiTinh, DiaChi, SDT,CMND ) VALUES  ('" + id + "',N'" + hoten + "', '" + ngaysinh + "',N'" + gioitinh + "',N'" + diachi + "','" + sdt + "','" + cmnd + "' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateDG(int id, string hoten, string ngaysinh, string gioitinh, string diachi, string sdt, int cmnd)
        {
            string query = "UPDATE dbo.DocGia SET HoTen = N'" + hoten + "', NgaySinh='" + ngaysinh + "', GioiTinh=N'" + gioitinh + "', DiaChi=N'" + diachi + "', SDT='" + sdt + "',CMND='" + cmnd + "' WHERE ID =" + id + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteDG(int id)
        {
            string query = "DELETE dbo.DocGia WHERE ID = " + id + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<DocGia> SearchDocGia(string name)
        {
            List<DocGia> listDG = new List<DocGia>();
            string query = string.Format("SELECT * FROM dbo.DocGia WHERE dbo.fuConvertToUnsign1(HoTen) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DocGia DG = new DocGia(item);
                listDG.Add(DG);
            }
            return listDG;
        }
    }
}
