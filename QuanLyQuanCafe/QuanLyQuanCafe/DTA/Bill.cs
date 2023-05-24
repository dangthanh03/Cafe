using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTA
{
    public  class Bill
    {
        private int iD;
        private DateTime? dateCHeckOut;
        private DateTime? dateCheckIN;
        private int idTable;
        private int payStatus;
        private float? Price;
        private int? Discount;
        public Bill(int id,DateTime datein,DateTime dateout,int table,int pay,int dis,float price) {
            this.iD = id;
            this.dateCheckIN = datein;
            this.dateCHeckOut = dateout;
            this.idTable = table;
            this.payStatus = pay;
            this.Discount1 = dis;
            this.Price1 = price;

        }


        public Bill(DataRow row) {
        this.iD = (int)row["id"];
            this.dateCheckIN = (DateTime)row["DateCheckIn"];
            if (row["DateCheckout"] == DBNull.Value) { this.dateCHeckOut = null; }
            else
            {
                this.dateCHeckOut = (DateTime)row["DateCheckout"];
            }
           
            this.idTable = (int)row["idTable"];
            this.payStatus = (int)row["PayStatus"];
            this.dateCheckIN = (DateTime)row["DateCheckIn"];
            if (row["Price"] == DBNull.Value) { this.Price = null; }
            else
            {
                this.Price = (float)row["Price"];
            }
            if (row["Discount"] == DBNull.Value) { this.Discount = null; }
            else
            {
                this.Discount = (int)row["Discount"];
            }

        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCHeckOut { get => dateCHeckOut; set => dateCHeckOut = value; }
        public DateTime? DateCheckIN { get => dateCheckIN; set => dateCheckIN = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int PayStatus { get => payStatus; set => payStatus = value; }
        public float? Price1 { get => Price; set => Price = value; }
        public int? Discount1 { get => Discount; set => Discount = value; }
    }
}
