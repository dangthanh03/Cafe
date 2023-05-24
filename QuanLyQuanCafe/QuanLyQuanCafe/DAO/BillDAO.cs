using QuanLyQuanCafe.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance {
            get { if (instance == null) { instance = new BillDAO(); }
                return instance; } 
                   set { instance = value; } }

        private BillDAO() { }

        public int GetUnCheckByTableId(int idtable)
        {

            DataTable result = DataProvider.Instance.ExecuteQuery("select * from Bill where  PayStatus=0 and  idTable = " + idtable);
            if (result.Rows.Count > 0) { 
                
                Bill bill = new Bill(result.Rows[0])  ;
                return bill.ID;
            }
            return -1;
        }

        public void AddBill(int idTable) {


            DataProvider.Instance.ExecuteQuery("exec ThemHoaDon @idTable ",new object[] {idTable});
        
        }
     
        public int GetMaxIDBIll()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from Bill");

            }
            catch { return -1; }
                         
            }

        public int Billlist(DateTime from ,DateTime to)
        {
          return (int) DataProvider.Instance.ExecuteScalar("exec  Get_List_BIll @checkin  ,  @checkout  ",new object[] {from,to});
          

        }

  
        public void PayBill(int BillId,int dis,float price) {

            DataProvider.Instance.ExecuteQuery("exec PayBIll @IdBill , @Dis , @PRice ",new object[] {BillId,dis,price});   
        }

        public DataTable GEtBIllByPage(DateTime checkin, DateTime checkout , int PageNum, int pageCount)
        {
          return   DataProvider.Instance.ExecuteQuery("exec GetListBillByPage @checkout  , @checkin  , @pageNum , @pageCount  ", new object[] { checkout,checkin,PageNum,pageCount });
        }

    }
}
