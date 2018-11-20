using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DTO
{
   public class DSPMS
    {
       public DSPMS(int id, string tensach, int soluong)
        {
            this.ID = id;
            this.TenSach = tensach;
            this.SoLuong = soluong;
        }

        public DSPMS(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TenSach = row["tensach"].ToString();
            this.SoLuong = (int)row["soluong"];
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
