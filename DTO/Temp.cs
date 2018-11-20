using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO
{
    public class Temp
    {
         public Temp(int idsach, string tensach,int soluong)
        {
            this.IDSach = idsach;
            this.TenSach = tensach;
            this.SoLuong = soluong;
        }

        public Temp(DataRow row)
        {
            this.IDSach = (int)row["idsach"];
            this.TenSach = row["tensach"].ToString();
            this.SoLuong = (int)row["soluong"];
        }
        private int IDSach;

        public int idsach
        {
            get { return IDSach; }
            set { IDSach = value; }
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
