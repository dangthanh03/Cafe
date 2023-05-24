using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
   public class DataProvider
    {
        private static DataProvider instance;

        string path = "Data Source=DESKTOP-K20D48Q;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public static DataProvider Instance { 
            get { if (instance == null) { instance = new DataProvider(); }
            return instance;
            } 
            private set { instance = value; } }

        public DataTable ExecuteQuery(string query, object[] para = null)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (para != null)
                {
                    string[] list = query.Split(' ');
                    int l = 0;
                    foreach(var i in list) {
                        if (i.Contains('@'))
                        {
                            command.Parameters.AddWithValue(i, para[l]);
                            l++;
                        }
                    }
                }
                connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            return table;
        }
        public int ExecuteNonQuery(string query, object[] para = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (para != null)
                {
                    string[] list = query.Split(' ');
                    int l = 0;
                    foreach (var i in list)
                    {
                        if (i.Contains('@'))
                        {
                            command.Parameters.AddWithValue(i, para[l]);
                            l++;
                        }
                    }
                }
            data= command.ExecuteNonQuery();
                connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
     
            }
            return data;
        }
        public  object ExecuteScalar(string query, object[] para = null)
        {
          object data = 0;
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (para != null)
                {
                    string[] list = query.Split(' ');
                    int l = 0;
                    foreach (var i in list)
                    {
                        if (i.Contains('@'))
                        {
                            command.Parameters.AddWithValue(i, para[l]);
                            l++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

            }
            return data;
        }
    }
}
