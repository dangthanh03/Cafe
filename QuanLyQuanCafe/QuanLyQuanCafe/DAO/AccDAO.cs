using QuanLyQuanCafe.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccDAO
    {
        private static AccDAO instance;

        public static AccDAO Instance { 
            get { if (instance == null) { instance = new AccDAO(); }return instance; }
           private set { instance = value; } }
    private AccDAO() { }

        public string GetPass(int id )
        {
         object count = DataProvider.Instance.ExecuteScalar("exec Getpass @id ", new object[] { id});
            return (string)count;

        }
        public bool AddAcc(string name,int type)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("exec AddAcc @Name , @type ", new object[] { name,type });
            return count > 0;
        }
        public bool UpdateAcc(int id, string name,int type)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("exec UpDataAccFromAdmin  @id , @name , @type ", new object[] { id, name,type });
            return count > 0;
        }
        public bool DeleAcc(int id)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("exec DeleteAcc @id ", new object[] { id });
            return count > 0;
        }
        public List<Account> GetAllAcc()
        {
            List<Account> list = new List<Account>();
            DataTable result = DataProvider.Instance.ExecuteQuery("select id , DisplayName, TypeACC from Account ");
            foreach (DataRow r in result.Rows)
            {
                Account account = new Account(r);
                list.Add(account);

            }
            return list;
        }
        public bool Login(string Name,string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            SHA512 sHA512 = SHA512.Create();
            byte[] hasData = sHA512.ComputeHash(temp);
            string data = "";

            foreach(var item in hasData)
            {
                data += item;
            }

            string query = "exec Login_DAO @user , @pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {Name,pass});
            return result.Rows.Count > 0;       

        }
        public Account GetAccountLog(string name)
        {
           DataTable acc=  DataProvider.Instance.ExecuteQuery("exec Get_acc_Login @name ",new object[] {name});
            foreach(DataRow r in acc.Rows)
            {
                Account account = new Account(r);
                return account;
            }
            return null;
        }

  
        public bool CheckAccForUpdate(string name, string pass, string newpass)
        {
           
                 int count=  DataProvider.Instance.ExecuteNonQuery(" exec UpDateAcc @name  , @OldPass  , @NewPass ", new object[] { name, pass, newpass });
            return count > 0;

        }


    }
}
