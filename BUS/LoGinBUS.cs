using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class LoGinBUS
    {
        public bool Login1(string user, string pass)
        {
            return new LoGinDAO().Login(user, pass);
        }
    }
}
