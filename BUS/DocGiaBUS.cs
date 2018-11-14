using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class DocGiaBUS
    {
        public List<DocGia> GetListDG()
        {
            return new DocGiaDAO().GetListDG();
        }
        public bool InsertDG(string hoten, string ngaysinh, string gioitinh, string diachi, string sdt, int cmnd, int id)
        {
            return new DocGiaDAO().InsertDG(hoten, ngaysinh, gioitinh, diachi, sdt, cmnd, id);
        }
        public bool UpdateDG(int id, string hoten, string ngaysinh, string gioitinh, string diachi, string sdt, int cmnd)
        {
            return new DocGiaDAO().UpdateDG(id, hoten, ngaysinh, gioitinh, diachi, sdt, cmnd);
        }
        public bool DeleteDG(int id)
        {
            return new DocGiaDAO().DeleteDG(id);
        }
        public List<DocGia> SearchDocGia(string name)
        {
            return new DocGiaDAO().SearchDocGia(name);
        }
        List<DocGia> SearchDG(string name)
        {
            List<DocGia> listDG = DocGiaDAO.Instance.SearchDocGia(name);
            return listDG;
        }
    }
}
