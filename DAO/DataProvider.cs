using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private string cnStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                cn.Open();

                SqlCommand command = new SqlCommand(query, cn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                cn.Close();
            }

            return data;
        }
        public int ExecuteNonQuery(string query)
        {
            int data = 0;

            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();

            SqlCommand command = new SqlCommand(query, cn);

            data = command.ExecuteNonQuery();

            cn.Close();

            return data;
        }
    }
}
