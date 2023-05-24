using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Fmanager : Form
    {
        private event EventHandler login;
        public event EventHandler Login
        {
            add { login += value; }
             remove { login -= value; }
        }

        private Account accLogin;


        public Account AccLogin { get => accLogin; set => accLogin = value;  }

        public Fmanager(Account acc)
        {
            this.accLogin = acc;
            InitializeComponent();
            LoadTable();
            LoadCategory();
            LoadTableCb(SwtchCb);
            ShowadMinFunc(acc.Type);
            DisplayNameOnToolStrip();
        }

        public void ShowadMinFunc(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
        }
        public void LoadTable()
        {
           List<Table> tables = DAO.TableDao.Instance.LoadTableList() ;

            foreach (var i in tables) {
            Button button = new Button() {Width=Table.TableWidth,Height=Table.TableHeight};
                button.Text = i.Name + Environment.NewLine + i.Status ;

                button.Tag = i;
                button.Click += Button_Click;
                switch (i.Status) {
                    case "1":
                        button.BackColor = Color.Red;
                        break;
                    default:
                        button.BackColor = Color.LightGreen;
                        break;

                }
                Flowpanel.Controls.Add(button);

            
            }
            
         }

        public void DisplayNameOnToolStrip()
        {

            thôngTinTàiKhoảnToolStripMenuItem.Text += " ( " + AccLogin.Name + " )";
        }
        public void ShowBill(int id)
        {
            BillLv.Items.Clear();
            List<Menu> list =MenuDAO.Instance.listmenu(id);
            float TotalPrice = 0;
            foreach (Menu menu in list) {
      
                ListViewItem name = new ListViewItem(menu.FoodName.ToString());
                name.SubItems.Add( menu.Soluong.ToString());
                name.SubItems.Add(menu.Price.ToString());
                TotalPrice += menu.Price * menu.Soluong;
                BillLv.Items.Add(name);
            }
            CultureInfo cultureInfo = new CultureInfo("vi-VN");

            txbTotalPrice.Text = TotalPrice.ToString("c",cultureInfo);


        }
        private void Button_Click(object? sender, EventArgs e)
        {
            int tableId = (((sender as Button).Tag) as Table ).ID;
            BillLv.Tag = (sender as Button).Tag;
            ShowBill(tableId);
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UserInfo userInfo = new UserInfo(AccLogin);
            userInfo.UpDateAcc += UserInfo_UpDateAcc;
            userInfo.Show();
        }

        private void UserInfo_UpDateAcc(object? sender, UserInfo.AccEventArg e)
        {
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin admin = new FAdmin();
            admin.UpdateForm += Admin_UpdateForm;
            admin.Delefood += Admin_Delefood;
            admin.UpdateTableForm += Admin_UpdateTableForm;
            admin.Acc = this.accLogin;
      
            admin.ShowDialog();
        }

     

        private void Admin_UpdateTableForm(object? sender, EventArgs e)
        {
            if (BillLv.Tag == null)
            {
                Flowpanel.Controls.Clear();
                LoadTable();
                LoadTableCb(SwtchCb);
                return;
            }
            int id = (BillLv.Tag as Table).ID;
            Flowpanel.Controls.Clear();
            LoadTable();
            LoadTableCb(SwtchCb);
            ShowBill(id);
        }

        private void Admin_Delefood(object? sender, EventArgs e)
        {
            if (BillLv.Tag == null)
            {
                LoadCategory();

                LoadFood((cbCAte.SelectedItem as Category).ID);
                return;
            }
            int id = (BillLv.Tag as Table).ID;
            LoadCategory();
           
            LoadFood((cbCAte.SelectedItem as Category).ID);
            Flowpanel.Controls.Clear();
            LoadTable();
            ShowBill(id);

        }

        private void Admin_UpdateForm(object? sender, EventArgs e)
        {
            if (BillLv.Tag == null)
            {
                LoadCategory();

                LoadFood((cbCAte.SelectedItem as Category).ID);
                return;
            }
            int id = (BillLv.Tag as Table).ID;
            LoadCategory();
            LoadFood((cbCAte.SelectedItem as Category).ID);
            Flowpanel.Controls.Clear();
            LoadTable();
            ShowBill(id);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LoadCategory()
        {
            List<Category> categories = CategoryDao.Instance.GetListCate();
            cbCAte.DataSource  = categories;
            cbCAte.DisplayMember = "Name";
        }
        void LoadFood(int id)
        {
            List<Food> foods = FoodDAO.Instance.GetListFoodByCateId(id);
            cbFood.DataSource = foods;
            cbFood.DisplayMember = "NAme";
        }
        private void cbCAte_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cbCAte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem  == null) { return; }
            Category cate = cb.SelectedItem as Category;
            id = cate.ID;
            LoadFood(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BillLv.Tag == null)
            {
                return;
            }
            numericUpDown2.Value = 0;
            int tableId = (BillLv.Tag as Table).ID;
            int idFooD = (cbFood.SelectedItem as Food).Id;
            int count = (int) numericUpDown1.Value;
            int IDBILL = BillDAO.Instance.GetUnCheckByTableId(tableId);
            if(IDBILL == -1)
            {
                BillDAO.Instance.AddBill(tableId);
                BillInfoDAO.Instance.AddBillInfo(BillDAO.Instance.GetMaxIDBIll(),idFooD,count);
                Flowpanel.Controls.Clear();
                LoadTable();

            }
            else
            {
                BillInfoDAO.Instance.AddBillInfo(IDBILL, idFooD, count);
          

            }

            ShowBill(tableId);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BillLv.Tag == null)
            {
                return;
            }
            txbTotalPrice.Text= 0.ToString("c",new CultureInfo("vi-VN"));
            Table tab = (BillLv.Tag as Table );
            int BillId = BillDAO.Instance.GetUnCheckByTableId(tab.ID);
            if(BillId == -1) {
                return;
            }
            else
            {
                List<Menu> list = MenuDAO.Instance.listmenu(tab.ID);
                float TotalPrice = 0;
                foreach (Menu menu in list)
                {

                    TotalPrice += menu.Price * menu.Soluong;

                }
                BillDAO.Instance.PayBill(BillId, (int)numericUpDown2.Value,TotalPrice -  (TotalPrice*( (float)numericUpDown2.Value)/100 ) );
                Flowpanel.Controls.Clear();
                LoadTable();
                BillLv.Items.Clear();
            }

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BillLv.Tag == null)
            {
                return;
            }
            float TotalPrice = 0;
            Table tab = (BillLv.Tag as Table);
            int BillId = BillDAO.Instance.GetUnCheckByTableId(tab.ID);
            if (BillId == -1)
            {
                return;
            }
            else
            {
                List<Menu> list = MenuDAO.Instance.listmenu(tab.ID);

                foreach (Menu menu in list)
                {

                    TotalPrice += menu.Price * menu.Soluong;

                }
                TotalPrice = TotalPrice - (TotalPrice * ((float)numericUpDown2.Value) / 100);

            }
            CultureInfo cultureInfo = new CultureInfo("vi-VN");

            txbTotalPrice.Text = TotalPrice.ToString("c", cultureInfo);

        }
        public void LoadTableCb(ComboBox cb) {

            cb.DataSource = TableDao.Instance.LoadTableList();
            cb.DisplayMember="Name";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BillLv.Tag == null)
            {
                return;
            }
            int id1 = (BillLv.Tag as Table).ID;
            int id2 = (SwtchCb.SelectedItem as Table).ID;
            if (BillDAO.Instance.GetUnCheckByTableId(id1) == -1 || BillDAO.Instance.GetUnCheckByTableId(id2) == -1)
            {
                return;
            }
            else {
                TableDao.Instance.SwitchTable(id1, id2);
                ShowBill(id1);
            }
        }

        private void thêmMónCtlrFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(this, new EventArgs());
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(this, new EventArgs ());
        }
    }
}
