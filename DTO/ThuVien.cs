using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO
{
    public class ThuVien
    {
        public ThuVien(int id, string tensach, string tentacgia, string nxb, string vitri, int soluong)
        {
            this.ID = id;
            this.TenSach = tensach;
            this.TenTacGia = tentacgia;
            this.NXB = nxb;
            this.ViTri = vitri;
            this.SoLuong = soluong;
        }

        public ThuVien(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TenSach = row["tensach"].ToString();
            this.TenTacGia = row["tentacgia"].ToString();
            this.NXB = row["nxb"].ToString();
            this.ViTri = row["vitri"].ToString();
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
        private string TenTacGia;

        public string tentacgia
        {
            get { return TenTacGia; }
            set { TenTacGia = value; }
        }
        private string NXB;

        public string nxb
        {
            get { return NXB; }
            set { NXB = value; }
        }
        private string ViTri;

        public string vitri
        {
            get { return ViTri; }
            set { ViTri = value; }
        }
        private int SoLuong;

        public int soluong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
    }
}
