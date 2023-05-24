using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTA;

namespace QuanLyQuanCafe
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sử muốn đóng ứng dụng ? ","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            { 
               e.Cancel = true;
            }
              
        }

        private void LogButt_Click(object sender, EventArgs e)
        {
            string userNam = NameInput.Text;
            string pas = PassInput.Text;
            if (Login(userNam,pas))
            {
                Account log = AccDAO.Instance.GetAccountLog(userNam);
                Fmanager f = new Fmanager(log);
                
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khảu không đúng");
            }
        }

      
        bool Login(string user,string pass)
        {
            return AccDAO.Instance.Login(user,pass);
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}