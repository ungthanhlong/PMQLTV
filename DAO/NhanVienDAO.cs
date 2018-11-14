using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;

namespace DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null)instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }
        public List<NhanVien> GetListNV()
        {
            List<NhanVien> listNV = new List<NhanVien>();

            string query = "SELECT * FROM dbo.NhanVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien NV = new NhanVien(item);
                listNV.Add(NV);
            }

            return listNV;
        }
        public bool InsertNV(string hoten, string ngaysinh, string gioitinh, string diachi, string sdt,int cmnd,int id)
        {
            string query = "INSERT INTO dbo.NhanVien ( ID, HoTen, NgaySinh, GioiTinh, DiaChi, SDT,CMND ) VALUES  ('"+id+"',N'" + hoten + "', '" + ngaysinh + "',N'" + gioitinh + "',N'" + diachi + "','" + sdt + "','"+cmnd+"' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateNV(int id, string hoten, string ngaysinh, string gioitinh, string diachi, string sdt,int cmnd)
        {
            string query = "UPDATE dbo.NhanVien SET HoTen = N'" + hoten + "', NgaySinh='" + ngaysinh + "', GioiTinh=N'" + gioitinh + "', DiaChi=N'" + diachi + "', SDT='" + sdt + "',CMND='"+cmnd+"' WHERE ID =" + id + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteNV(int id)
        {
            string query = "DELETE dbo.NhanVien WHERE ID = " + id + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<NhanVien> SearchNhanVien(string name)
        {
            List<NhanVien> listNV = new List<NhanVien>();
            string query = string.Format("SELECT * FROM dbo.NhanVien WHERE dbo.fuConvertToUnsign1(HoTen) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien NV = new NhanVien(item);
                listNV.Add(NV);
            }
            return listNV;
        }
    }
}
