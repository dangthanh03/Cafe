using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTA
{
      public class Food
    {
        private string nAme;
        private int id;
        private int cAteid;
        private double price;
        

        public Food(string name,int id , int catename,double price) {

            this.nAme = name;
            this.id = id;
            this.cAteid= catename;
            this.price = price; 
        
        }


        public Food(DataRow row) {

            this.nAme = row["FoodName"].ToString();
            this.id = (int)row["id"];
            this.cAteid = (int)row["idCate"];
            this.price = (double)Convert.ToDouble(row["Price"]);
        
        }


        public int Id { get => id; set => id = value; }
        public string NAme { get => nAme; set => nAme = value; }
        public int  CAteid { get => cAteid; set => cAteid = value; }
        public double Price { get => price; set => price = value; }
    }
}
