using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTA
{
    public class Table
    {
        public static int TableWidth= 80;
        public static int TableHeight = 80;
        private int iD;
        private string name;
        private string status;
        public int ID { get => iD; set => iD = value; }
        public string Name { get =>name; set => name = value; }
        public string Status { get => status; set => status = value; }

        public Table(int id,string name,string status) {
            this.ID = id;
            this.Name = name;
            this.status = status;
        }

        public Table(DataRow row) {
        this.ID = (int)row["id"];
            this.Name = row["TableName"].ToString();
            this.Status = row["TableStatus"].ToString();
        
        }
    }
}
