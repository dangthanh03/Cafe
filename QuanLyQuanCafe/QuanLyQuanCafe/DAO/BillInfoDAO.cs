using QuanLyQuanCafe.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillInfoDAO
    {

        private static BillInfoDAO instance;

        public static BillInfoDAO Instance {
            get
            {
                if (instance == null) { instance = new BillInfoDAO(); }
                return instance;
            }
            set { instance = value; }
        }
        private BillInfoDAO() { }   
        public List<BillInFo> getListBillInfo(int idbill)
        {
            List<BillInFo> list = new List<BillInFo>();
            DataTable result = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idBill = "+idbill);
            foreach(DataRow row in result.Rows)
            {
                BillInFo billinfo = new BillInFo(row);
                list.Add(billinfo);
            }
            return list;
        }

        public void AddBillInfo(int BIllID,int foodid,int foodquanity)
        {

            DataProvider.Instance.ExecuteQuery("exec  Add_CHI_TIET_HOADON  @idBILL , @idFood , @FoodQuanity ", new object[] {BIllID,foodid,foodquanity});

        }
        

    }
}
