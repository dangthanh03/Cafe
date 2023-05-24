using QuanLyQuanCafe.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class MenuDAO
    {

        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null) { instance = new MenuDAO(); }
                return instance;
            }
            set { instance = value; }
        }
        private MenuDAO() { }

        public List<Menu> listmenu(int idTable)
        {
            List<Menu> list = new List<Menu>();
            DataTable result = DataProvider.Instance.ExecuteQuery("select b.idTable,f.FoodName,bi.SoluongFood,f.Price from  Bill b left join BillInfo BI on b.id = bi.idBill left join Food f on Bi.idFood = f.id where  b.PayStatus=0 and   b.idTable = " + idTable);
            foreach (DataRow r in result.Rows) {
                Menu menu = new Menu(r);
                list.Add(menu);
            
            
            }
            return list;

        }
     
    }
}
