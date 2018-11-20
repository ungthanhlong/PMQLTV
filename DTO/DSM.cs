using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO
{
    public class DSM
    {
        public DSM(int iddocgia, string tendocgia,int idbill,DateTime? ngaymuon)
        {
            this.IDDocGia = iddocgia;
            this.TenDocGia = tendocgia;
            this.IDBill = idbill;
            this.NgayMuon = ngaymuon;
        }

        public DSM(DataRow row)
        {
            this.IDDocGia = (int)row["id"];
            this.TenDocGia = row["hoten"].ToString();
            this.IDBill = (int)row["idbill"];
            this.NgayMuon = (DateTime?)row["ngaymuon"];
        }
        private int IDDocGia;

        public int iddocgia
        {
            get { return IDDocGia; }
            set { IDDocGia = value; }
        }
        private string TenDocGia;

        public string tendocgia
        {
            get { return TenDocGia; }
            set { TenDocGia = value; }
        }
        private int IDBill;

        public int idbill
        {
            get { return IDBill; }
            set { IDBill = value; }
        }
        private DateTime? NgayMuon;

        public DateTime? ngaymuon
        {
            get { return NgayMuon; }
            set { NgayMuon = value; }
        }
    }
}
