using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTA
{
    public class Account
    {
        private int id;
        private string name;
        private string? pass;
        private int type;

        public Account(string name, int type, int id, string pass = null)
        {
            Id = id;
            Name = name;
            Pass = pass;
            Type = type;
        
         }

        public Account(DataRow data) {
            Id = (int)data["id"];


            Name = data["DisplayName"].ToString();
            if (data.Table.Columns.Contains("Pass"))
            {
                Pass = data["Pass"].ToString();
            }
            else
            {
                Pass = null;
            }
            Type = (int)data["TypeAcc"];
        
        }

        public string Name { get => name; set => name = value; }
        public string? Pass { get => pass; set => pass = value; }
        public int Type { get => type; set => type = value; }
        public int Id { get => id; set => id = value; }
    }
}
