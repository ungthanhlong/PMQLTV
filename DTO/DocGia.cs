using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO
{
    public class DocGia
    {
        public DocGia(int id, string hoten, string ngaysinh, string gioitinh, string sdt, string diachi, int cmnd)
        {
            this.ID = id;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.SDT = sdt;
            this.DiaChi = diachi;
            this.CMND = cmnd;
        }

        public DocGia(DataRow row)
        {
            this.ID = (int)row["id"];
            this.HoTen = row["hoten"].ToString();
            this.NgaySinh = row["ngaysinh"].ToString();
            this.GioiTinh = row["gioitinh"].ToString();
            this.SDT = row["sdt"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.CMND = (int)row["cmnd"];
        }
        private int ID;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        private string HoTen;

        public string hoten
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        private string NgaySinh;

        public string ngaysinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        private string GioiTinh;

        public string gioitinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        private string SDT;

        public string sdt
        {
            get { return SDT; }
            set { SDT = value; }
        }
        private string DiaChi;

        public string diachi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        private int CMND;

        public int cmnd
        {
            get { return CMND; }
            set { CMND = value; }
        }
    }
}
