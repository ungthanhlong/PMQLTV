using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class PhieuMuonBUS
    {
        public List<PhieuMuon> GetListPM()
        {
            return new PhieuMuonDAO().GetListPM();
        }
        public List<PhieuMuon> SearchPhieuMuon(string name)
        {
            return new PhieuMuonDAO().SearchPhieuMuon(name);
        }
    }
}
