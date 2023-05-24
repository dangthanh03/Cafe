using QuanLyQuanCafe.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class CategoryDao
    {
        private static CategoryDao instance;

        public static CategoryDao Instance
        {
            get
            {
                if (instance == null) { instance = new CategoryDao(); }
                return instance;
            }
            set { instance = value; }
        }

        private CategoryDao() { }

        public Category GetCateFromID(int id)
        {
     DataTable result = DataProvider.Instance.ExecuteQuery("select * from FoodCategory where id = "+id);
            foreach (DataRow r in result.Rows)
            {

                Category category = new Category(r);
                return category;
            }
            return null;
        }

        public List<Category> GetListCate()
        {
            List<Category> list = new List<Category>(); 
            DataTable result = DataProvider.Instance.ExecuteQuery("select * from FoodCategory");
            foreach( DataRow r in result.Rows)
            {

               Category category = new Category(r);
               list.Add(category);
            }
            return list;        
        }

        public bool AddCateGory(string name)
        {
          int count=   DataProvider.Instance.ExecuteNonQuery("exec AddCate @name ",new object[] {name});
            return count > 0;
        }
        public bool UpdateCateGory(int id,string name)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("exec UpDateCate  @id , @name  ", new object[] {id, name });
            return count > 0;
        }
        public bool DeleCateGory(int id)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("exec DeleCate @idCate  ", new object[] { id });
            return count > 0;
        }

    }
}
