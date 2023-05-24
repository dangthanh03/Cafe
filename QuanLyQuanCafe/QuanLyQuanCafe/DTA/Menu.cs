using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTA
{
    public class Menu
    {
        private string foodName;
        private int soluong;
        private float price;
        public Menu(DataRow row) {

            this.foodName = row["FoodName"].ToString();
            if (row["SoLuongFood"] == DBNull.Value) { this.Soluong = -1; }
            else
            {
                this.soluong = (int)row["SoLuongFood"];
            }
            if (row["Price"] == DBNull.Value) { this.price = -1; }
            else
            {
                this.price = Convert.ToSingle(row["Price"]);
            }
            
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Price { get => price; set => price = value; }
    }
}
