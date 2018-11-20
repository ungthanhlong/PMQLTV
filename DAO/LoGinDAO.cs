using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class LoGinDAO
    {
        private static LoGinDAO instance;

        public static LoGinDAO Instance
        {
            get { if (instance == null)instance = new LoGinDAO(); return LoGinDAO.instance; }
            private set { LoGinDAO.instance = value; }
        }
        public bool Login(string user, string pass)
        {
            string query = "SELECT COUNT(UserName) FROM DangNhap  WHERE UserName = '" + user + "' AND PassWord = '" + pass + "'";
            return DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
