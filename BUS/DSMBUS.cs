using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class DSMBUS
    {
        public List<DSM> GetListDS()
        {
            return new DSMDAO().GetListDS();
        }
        public List<DSM> SearchDSM(string name)
        {
            return new DSMDAO().SearchDSM(name);
        }
        public List<XemMuonSach> GetListXS()
        {
            return new DSMDAO().GetListXS();
        }
        public List<XemMuonSach> SearchXS(string name)
        {
            return new DSMDAO().SearchXS(name);
        }
        public bool TraSach(int id)
        {
            return new DSMDAO().TraSach(id);
        }
    }
}
