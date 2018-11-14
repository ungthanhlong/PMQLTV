using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class ThuVienDAO
    {
        private static ThuVienDAO instance;

        public static ThuVienDAO Instance
        {
            get { if (instance == null)instance = new ThuVienDAO(); return ThuVienDAO.instance; }
            private set { ThuVienDAO.instance = value; }
        }
        public List<ThuVien> GetListTV()
        {
            List<ThuVien> listTV = new List<ThuVien>();

            string query = "SELECT DISTINCT * FROM dbo.ThuVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThuVien TV = new ThuVien(item);
                listTV.Add(TV);
            }

            return listTV;
        }
        public bool InsertSach( int id, string tensach, string tentg, string nxb)
        {
            string query = "INSERT INTO dbo.Sach(ID,TenSach, TenTacGia,NXB) VALUES("+id+", N'" + tensach + "',N'" + tentg + "',N'" + nxb + "')";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public bool InsertViTri(string vitri, int soluong, int id)
        {
            string query = "INSERT INTO dbo.ViTri(IDSach,ViTri,SoLuong) VALUES( " + id + ",N'" + vitri + "', " + soluong + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteSach(int id)
        {
            string query = "DELETE dbo.Sach WHERE ID = "+id+"";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteVitri(int id)
        {
            string query = "DELETE dbo.ViTri WHERE IDSach = " + id + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateSach(int id, string tensach, string tentg, string nxb)
        {
            string query = "UPDATE dbo.Sach SET TenSach=N'" + tensach + "', TenTacGia=N'" + tentg + "', NXB=N'" + nxb + "'  WHERE ID =" + id + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateViTri(string vitri, int soluong, int id)
        {
            string query = "UPDATE dbo.ViTri SET ViTri=N'" + vitri + "', SoLuong=" + soluong + "  WHERE ID =" + id + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<ThuVien> SearchThuVien(string name)
        {
            List<ThuVien> listTV = new List<ThuVien>();
            string query = string.Format("SELECT * FROM dbo.ThuVien WHERE dbo.fuConvertToUnsign1(TenSach) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThuVien TV = new ThuVien(item);
                listTV.Add(TV);
            }
            return listTV;
        }
    }
}
