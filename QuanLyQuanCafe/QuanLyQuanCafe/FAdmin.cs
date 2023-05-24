using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTA;
using System.Diagnostics.Tracing;

namespace QuanLyQuanCafe
{


    public partial class FAdmin : Form
    {
        private event EventHandler login;
        public event EventHandler Login
        {
            add { login += value; }
            remove { login -= value; }
        }
        private Account acc;
        BindingSource AccBindSource = new BindingSource();
        BindingSource TableBindSource = new BindingSource();
        BindingSource FoodBindSource = new BindingSource();
        BindingSource CateBindSource = new BindingSource();

        public Account Acc { get => acc; set => acc = value; }

        private event EventHandler updateTable;
        public event EventHandler UpdateTableForm
        {
            add
            {
                updateTable += value;
            }

            remove
            {
                updateTable -= value;
            }
        }
        private event EventHandler update;
        public event EventHandler UpdateForm
        {
            add
            {
                update+=value;
            }

            remove
            {
                update -= value;    
            }
        }
        private event EventHandler delefood;
        public event EventHandler Delefood
        {
            add
            {
                delefood += value;
            }

            remove
            {
                delefood -= value;
            }
        }


        public FAdmin()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            LoadCategory();
            LoadFood();
            LoadBox();
            DateTimePicker();
            GEtListBill(FromDate.Value, ToDate.Value);
            LoadCategoryGRidview();
            LoadBoxCate();
            LoadTableGRidview();
            LoadBoxTable();
            LoadAccGRidview();
            LoadBoxAcc();
        }




        #region method

        public void UpdateACC()
        {
            int id = int.Parse(IDAccInput.Text);
            string name = DisplayNameIn.Text;
            int type = int.Parse(AccTypeInput.Text);
            if (AccDAO.Instance.UpdateAcc(id,name,type))
            {
                MessageBox.Show("Đã cập nhật tài khoản thành công thành công");
                LoadAccGRidview();
              
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại");
            }
        }

        public void DeleteACC()
        {
            int id = int.Parse(IDAccInput.Text);
            if(id == Acc.Id) {
                MessageBox.Show("Tài khoản đang đăng  nhập, không thể xóa");
                return;
                
            }
            if (AccDAO.Instance.DeleAcc(id))
            {
                MessageBox.Show("Đã xóa tài khoản thành công thành công");
                LoadAccGRidview();

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại");
            }
        }
        public void UpdateTableDataGridView()
        {
            int id = int.Parse(IDTableInput.Text);
            string name = TableNameIn.Text;
            if (TableDao.Instance.UpdateTable(id, name))
            {
                MessageBox.Show("Đã cập nhật bàn thành công");
                LoadTableGRidview();
                if (updateTable != null)
                {
                    updateTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại");
            }
        }
        public void AddTableDataGridView()
        {
            string name = TableNameIn.Text;
            if (TableDao.Instance.AddTable(name))
            {
                MessageBox.Show("Đã thêm bàn thành công");
                LoadTableGRidview();
                if (updateTable != null)
                {
                    updateTable(this, new EventArgs());
                }

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại");
            }
        }
        public void LoadCategoryGRidview() {

            CateBindSource.DataSource = CategoryDao.Instance.GetListCate();
        
        }
        public void LoadAccGRidview()
        {

            AccBindSource.DataSource = AccDAO.Instance.GetAllAcc();
           

        }
      
        public void LoadBoxAcc()
        {
           AccDataView.DataSource = AccBindSource;
            AccDataView.Columns[1].Visible = false;
            
            AccDataView.Columns[2].DisplayIndex = 3;
            AccDataView.Columns[0].DisplayIndex = 2;


            IDAccInput.DataBindings.Add(new Binding("Text", AccDataView.DataSource, "Id", true, DataSourceUpdateMode.Never));
            DisplayNameIn.DataBindings.Add(new Binding("Text", AccDataView.DataSource, "name", true, DataSourceUpdateMode.Never));
            AccTypeInput.DataBindings.Add(new Binding("Text", AccDataView.DataSource, "type", true, DataSourceUpdateMode.Never));
            
        }
        public void LoadTableGRidview()
        {

            TableBindSource.DataSource = TableDao.Instance.LoadTableList();

        }

        public void LoadBoxTable()
        {
            TableGridView.DataSource = TableBindSource;
            IDTableInput.DataBindings.Add(new Binding("Text", TableGridView.DataSource, "ID", true, DataSourceUpdateMode.Never));
            TableNameIn.DataBindings.Add(new Binding("Text", TableGridView.DataSource, "Name", true, DataSourceUpdateMode.Never));
            StatusTableIn.DataBindings.Add(new Binding("Text", TableGridView.DataSource, "Status", true, DataSourceUpdateMode.Never));

        }


        public void LoadBoxCate()
        {
            CateGridView.DataSource = CateBindSource;
            CateIdText.DataBindings.Add(new Binding("Text",CateGridView.DataSource,"ID", true, DataSourceUpdateMode.Never));
            CatetextBox.DataBindings.Add(new Binding("Text", CateGridView.DataSource, "Name", true, DataSourceUpdateMode.Never));

        }


        private void EditFoodButt_Click(object sender, EventArgs e)
        {
            if (FoodDAO.Instance.UpdateFood(int.Parse(FoodId.Text), FoodName.Text, (int)(AdminFoodCateCb.SelectedItem as Category).ID, (float)FoodPrice.Value))
            {
                MessageBox.Show("Món ăn đã được cập nhật");
                LoadFood();
                if (update != null)
                {
                    update(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại");

            }
        }

        private void DeleteFoodButt_Click(object sender, EventArgs e)
        {
            if (FoodDAO.Instance.DeleteFood(int.Parse(FoodId.Text)))
            {
                MessageBox.Show("Món ăn đã bị xóa ");
                LoadFood();
                if (delefood != null)
                {
                    delefood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại");

            }
        }

        public void SearchFood()
        {
            List<Food> foods = new List<Food>();
            foods = FoodDAO.Instance.GetSearchFood(FoodSearchInput.Text);

            FoodGridView.DataSource = foods;


        }
        private void SearchButt_Click(object sender, EventArgs e)
        {
            SearchFood();
        }
        public void LoadCategory()
        {
           AdminFoodCateCb.DataSource= CategoryDao.Instance.GetListCate();
            AdminFoodCateCb.DisplayMember = "Name";
        }
        public void LoadBox()
        {

            FoodGridView.DataSource = FoodBindSource;
            FoodGridView.Columns[1].HeaderText = "Tên món ăn";
            FoodGridView.Columns[1].DataPropertyName="NAme";
            FoodGridView.Columns[2].HeaderText = "Loại món ăn";
            FoodGridView.Columns[2].DataPropertyName = "CAteid";

            FoodGridView.Columns[3].HeaderText = "Giá tiền";
            FoodGridView.Columns[3].DataPropertyName = "Price";


            FoodId.DataBindings.Add(new Binding("Text",FoodGridView.DataSource,"id",true,DataSourceUpdateMode.Never));
            FoodName.DataBindings.Add(new Binding("Text", FoodGridView.DataSource, "NAme", true, DataSourceUpdateMode.Never));


            FoodPrice.DataBindings.Add(new Binding("Value", FoodGridView.DataSource, "Price", true, DataSourceUpdateMode.Never));

        }
        public void DateTimePicker() {
            DateTime today = DateTime.Now;
            FromDate.Value = new DateTime(today.Year,today.Month,1);
           ToDate.Value = FromDate.Value.AddMonths(1).AddDays(-1);

        }
        public  bool IsNumeric(string input)
        {
            int result;
            if (int.TryParse(input, out result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void GEtListBill(DateTime from , DateTime to)
        {
            if (!IsNumeric(PageBox.Text)) { return; } else {
                BillGridView.DataSource = BillDAO.Instance.GEtBIllByPage(from, to, int.Parse(PageBox.Text),NummberRowForPage);
            }
        }

        public void LoadFood()
        {
            FoodBindSource.DataSource = FoodDAO.Instance.GetAllFood();
        }
        #endregion

        private void FoodId_TextChanged(object sender, EventArgs e)
        {
            if (FoodGridView.SelectedCells.Count > 0)
            {
                int id = (int)FoodGridView.SelectedCells[0].OwningRow.Cells["CAteid"].Value;

                Category cate = CategoryDao.Instance.GetCateFromID(id);
                int index = -1;
                int i = 0;
                foreach (Category item in AdminFoodCateCb.Items)
                {
                    if (item.ID == cate.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;

                }
                AdminFoodCateCb.SelectedIndex = index;
            }


        }
        private void CheckBill_Click(object sender, EventArgs e)
        {
            PageBox.Text = "1";
            GEtListBill(FromDate.Value,ToDate.Value);

        

        }

        public void AddAcc()
        {
            string name = DisplayNameIn.Text;
            int id = int.Parse(AccTypeInput.Text);
            if (AccDAO.Instance.AddAcc(name,id))
            {
                MessageBox.Show("Đã thêm tài khoản thành công");
                LoadAccGRidview();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau");

            }
        }

       

        public void AddCategory()
        {
            string name = CatetextBox.Text;
          if(CategoryDao.Instance.AddCateGory(name))
            {
                MessageBox.Show("Đã thêm danh mục thành công");
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau");

            }
        }

        public void UpdateCategory()
        {
            int id = int.Parse(CateIdText.Text);
            string name = CatetextBox.Text;
            if (CategoryDao.Instance.UpdateCateGory(id,name))
            {
                MessageBox.Show("Đã cập nhật danh mục thành công");
                LoadCategoryGRidview();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau");

            }
        }

        public void DeleCategory()
        {
            int id = int.Parse(CateIdText.Text);
            if (CategoryDao.Instance.DeleCateGory(id))
            {
                MessageBox.Show("Đã xóa danh mục thành công");
                LoadCategoryGRidview();
              
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau");

            }
        }

        #region event 
        private void AddCate_Click(object sender, EventArgs e)
        {
            AddCategory();
            LoadCategoryGRidview();
            if (update != null)
            {
                update(this, new EventArgs());
            }
        }
        private void AddFoodButt_Click(object sender, EventArgs e)
        {
            if (FoodDAO.Instance.AddFood(FoodName.Text, (int)(AdminFoodCateCb.SelectedItem as Category).ID, (float)FoodPrice.Value))
            {
                MessageBox.Show("Món ăn đã được cập nhật");
                LoadFood();
                if (update != null)
                {
                    update(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại");

            }

        }
        private void TcFood_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabBill_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }

        private void TcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabCate_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TcAccount_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        #endregion

      

       

        private void CateGridView_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {
           
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            UpdateCategory();
            if (update != null)
            {
                update(this, new EventArgs());
            }
        }

        private void DeleButt_Click(object sender, EventArgs e)
        {
            DeleCategory();
            if (delefood != null)
            {
                delefood(this, new EventArgs());
            }
        }

        private void TableAddButt_Click(object sender, EventArgs e)
        {
            AddTableDataGridView();
        }

        private void TableEditButt_Click(object sender, EventArgs e)
        {
            UpdateTableDataGridView();
        }
        public void DeleteTable()
        {
            int id = int.Parse(IDTableInput.Text);

            if (TableDao.Instance.DeleTable(id))
            {
                MessageBox.Show("Đã xóa bàn");
                LoadTableGRidview();
                if (updateTable != null)
                {
                    updateTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại");

            }

        }

        private void TableDeleteButt_Click(object sender, EventArgs e)
        {
            DeleteTable();
        }

     
        private void AddAccountButt_Click(object sender, EventArgs e)
        {
            AddAcc();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void EditAccountButt_Click(object sender, EventArgs e)
        {
            UpdateACC();
        }

        private void DeleteAccountButt_Click(object sender, EventArgs e)
        {
            DeleteACC();
        }

        private void ResetPassButt_Click(object sender, EventArgs e)
        {
            ResetPass reset = new ResetPass(int.Parse(IDAccInput.Text), DisplayNameIn.Text);
   
            reset.ShowDialog();

        }

        private void PageBox_TextChanged(object sender, EventArgs e)
        {
            GEtListBill(FromDate.Value,ToDate.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageBox.Text = "1";
        }
        public  int StringToInt(string input)
        {
            int result;
            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                throw new Exception("Chuỗi đầu vào không phải là số nguyên.");
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!IsNumeric(PageBox.Text))
            {
                return;
            }
            else
            {
                if(StringToInt(PageBox.Text)== 1)
                {
                    return;
                }
                else
                {
                    int temp = StringToInt(PageBox.Text)-1;
                    PageBox.Text = temp.ToString();
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PageBox.Text = CalculateMaxPage().ToString();
        }

        public int CalculateMaxPage()
        {
            int last = BillDAO.Instance.Billlist(FromDate.Value, ToDate.Value) / NummberRowForPage;
            if (BillDAO.Instance.Billlist(FromDate.Value, ToDate.Value) % NummberRowForPage > 0)
            {
                last++;

            }

            return last;

        }
        public static int NummberRowForPage = 10;

        private void button4_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(PageBox.Text))
            {
                return;
            }
            else
            {
                if (StringToInt(PageBox.Text) >= CalculateMaxPage())
                {
                    return;
                }
                else
                {
                    int temp = StringToInt(PageBox.Text) + 1;
                    PageBox.Text = temp.ToString();
                }

            }

        }
    }

}