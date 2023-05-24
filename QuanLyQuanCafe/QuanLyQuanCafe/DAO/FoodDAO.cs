
using QuanLyQuanCafe.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) { instance = new FoodDAO(); }
                return instance;
            }
            set { instance = value; }
        }

        public List<Food> GetAllFood() {
            List<Food> list = new List<Food>();
            DataTable result = DataProvider.Instance.ExecuteQuery("select  f.id   , f.FoodName  ,f.idCate , f.Price  from Food f ");
            foreach (DataRow r in result.Rows)
            {
                Food food = new Food(r);
                list.Add(food);

            }
            return list;
        }

        private FoodDAO() { }

        public List<Food> GetListFoodByCateId(int id)
        {
            List<Food> list = new List<Food>();
            DataTable result = DataProvider.Instance.ExecuteQuery("select  f.id   , f.FoodName  ,f.idCate , f.Price  from Food f  where idCate = " + id);
            foreach (DataRow r in result.Rows)
            {
                Food food = new Food(r);
                list.Add(food);

            }
            return list;
        }

        public bool AddFood(string name , int cate , float price) {

            
            int count = DataProvider.Instance.ExecuteNonQuery("exec AddFood @Name , @Cate  , @price   ",new object[] {name,cate,price});
            return count == 1;

        }
        public bool UpdateFood(int id,string name, int cate, float price)
        {


            int count = DataProvider.Instance.ExecuteNonQuery(" exec UpDateFood @Name , @Cate  , @price  , @id   ", new object[] { name, cate, price, id });
            return count == 1;

        }

        public bool DeleteFood(int id)
        {


            int count = DataProvider.Instance.ExecuteNonQuery(" exec DeleteFood @id    ", new object[] { id });
            return count >0;

        }
        public List<Food> GetSearchFood(string name)
        {
            List<Food> list = new List<Food>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec Search @input  ", new object[] { name }) ;
            foreach (DataRow r in result.Rows)
            {
                Food food = new Food(r);
                list.Add(food);

            }
            return list;


        }
    }
}
