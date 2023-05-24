using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTA
{
    public class BillInFo
    {
        private int idBill;
        private int id;
        private int idFood;
        private int soluong;

        public BillInFo(int iD,int idbill,int idfood,int soluonG) {
            this.id = iD;
            this.idFood = idfood;
            this.idBill = idbill;
            this.soluong= soluonG;


        }

        public BillInFo(DataRow row) {

            this.id = (int)row["id"];
            this.idFood = (int)row["idFood"];
            this.idBill = (int)row["idBill"];
            this.soluong = (int)row["SoLuongFood"];
        
        }


        public int IdBill { get => idBill; set => idBill = value; }
        public int Id { get => id; set => id = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
