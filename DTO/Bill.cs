using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO
{
    public class Bill
    {
         public Bill(int id,int iddocgia,int idsach, string tensach,int soluong)
        {
            this.ID = id;
            this.IDDocGia = iddocgia;
            this.IDSach = idsach;
            this.TenSach = tensach;
            this.SoLuong = soluong;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["idsach"];
            this.IDDocGia = (int)row["iddocgia"];
            this.IDSach = (int)row["idsach"];
            this.TenSach = row["tensach"].ToString();
            this.SoLuong = (int)row["soluong"];
        }
        private int IDDocGia;

        public int iddocgia
        {
            get { return IDDocGia; }
            set { IDDocGia = value; }
        }
        private int IDSach;

        public int idsach
        {
            get { return IDSach; }
            set { IDSach = value; }
        }
        private int ID;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        private string TenSach;

        public string tensach
        {
            get { return TenSach; }
            set { TenSach = value; }
        }
        private int SoLuong;

        public int soluong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
    }
}
