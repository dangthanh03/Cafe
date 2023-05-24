using QuanLyQuanCafe.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDao
    {

        private static TableDao instance;

        public static TableDao Instance
        {
            get { if (instance == null) { instance = new TableDao(); } return instance; }
            set { instance = value; }
        }
        private TableDao() { }

        public List<Table> LoadTableList()
        {
            List<Table> list = new List<Table>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec Get_Table");

            foreach (DataRow i in result.Rows)
            {
                Table table = new Table(i);
                list.Add(table);
            }
            return list;

        }
        public bool DeleTable(int id)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("exec DeleteTable @idTable  ", new object[] {id });
            return count > 0;
        }

        public bool AddTable(string name)
        {
            int count= DataProvider.Instance.ExecuteNonQuery("exec AddTable @name ", new object[] {name} );
            return count > 0;
        }
        public bool UpdateTable(int id,string name)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("exec Update_table @id , @name ", new object[] { id,name });
            return count > 0;
        }

        public void SwitchTable(int idTable1,int idTable2) {
            DataProvider.Instance.ExecuteQuery("exec switch_table  @iDTable1 ,  @iDTable2",new object[] {idTable1,idTable2});
        
        }

    }
}
