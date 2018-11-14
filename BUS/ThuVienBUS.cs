using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ThuVienBUS
    {
        public List<ThuVien> GetListTV()
        {
            return new ThuVienDAO().GetListTV();
        }
        public bool InsertSach(int id, string tensach, string tentg, string nxb)
        {
            return new ThuVienDAO().InsertSach( id, tensach,tentg,nxb);
        }
        public bool InsertViTri(string vitri, int soluong, int id)
        {
            return new ThuVienDAO().InsertViTri(vitri, soluong, id);
        }
        public bool DeleteSach(int id)
        {
            return new ThuVienDAO().DeleteSach(id);
        }
        public bool DeleteVitri(int id)
        {
            return new ThuVienDAO().DeleteVitri(id);
        }
        public bool UpdateSach(int id, string tensach, string tentg, string nxb)
        {
            return new ThuVienDAO().UpdateSach(id, tensach, tentg, nxb);
        }
        public bool UpdateViTri(string vitri, int soluong, int id)
        {
            return new ThuVienDAO().UpdateViTri(vitri, soluong, id);
        }
        public List<ThuVien> SearchThuVien(string name)
        {
            return new ThuVienDAO().SearchThuVien(name);
        }
    }
}
