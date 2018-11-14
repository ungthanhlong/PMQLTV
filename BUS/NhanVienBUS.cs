using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        public List<NhanVien> GetListNV()
        {
            return new NhanVienDAO().GetListNV();
        }
        public bool InsertNV(string hoten, string ngaysinh, string gioitinh, string diachi, string sdt, int cmnd, int id)
        {
            return new NhanVienDAO().InsertNV(hoten, ngaysinh, gioitinh, diachi, sdt,cmnd,id);
        }
        public bool UpdateNV(int id, string hoten, string ngaysinh, string gioitinh, string diachi, string sdt, int cmnd)
        {
            return new NhanVienDAO().UpdateNV(id, hoten, ngaysinh, gioitinh, diachi, sdt,cmnd);
        }
        public bool DeleteNV(int id)
        {
            return new NhanVienDAO().DeleteNV(id);
        }
        public List<NhanVien> SearchNhanVien(string name)
        {
            return new NhanVienDAO().SearchNhanVien(name);
        }
        List<NhanVien> SearchNV(string name)
        {
            List<NhanVien> listNV = NhanVienDAO.Instance.SearchNhanVien(name);
            return listNV;
        }
    }
}
