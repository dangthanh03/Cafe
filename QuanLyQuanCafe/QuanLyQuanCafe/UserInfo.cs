using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
   
    public partial class UserInfo : Form
    {
        private Account accLogin;
        
        public Account AccLogin { get => accLogin; set => accLogin = value; }
        public UserInfo(Account acc)
        {
            InitializeComponent();
            AccLogin = acc;

            ShowInfo();
        }

        private event EventHandler<AccEventArg> upDateAcc;
        public event EventHandler<AccEventArg> UpDateAcc
        {
            add
            {
                upDateAcc+=value;
            }
            remove
            {
                upDateAcc-=value;
            }
        }

        public class AccEventArg : EventArgs
        {
            private Account acc;
            public AccEventArg(Account acc) {
                this.acc = acc;
            }
            public Account Acc { get => acc; set => acc = value; }
        }

        public void ShowInfo()
        {

            NameInput.Text = AccLogin.Name;


        }

        private void LoginText_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {

        }
        public bool CHeckAcc(string name,string pass ,string New)
        {
            return AccDAO.Instance.CheckAccForUpdate(name, pass, New);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thay đổi thông tin tài khoản ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string name = NameInput.Text;
                string oldpass = textBox2.Text;
                string newpass = textBox3.Text;
                string reenterNewPas = textBox4.Text;
                if (!newpass.Equals(reenterNewPas))
                {
                    MessageBox.Show("Mật khẩu mới không khớp !");
                }
                else
                {
                    if (CHeckAcc(name, oldpass, newpass))
                    {
                       
                        upDateAcc(this,new AccEventArg(AccDAO.Instance.GetAccountLog(name)));
                      
                        MessageBox.Show("Mật khẩu đã được thay đổi");
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng mật khẩu và tên đăng nhập ");
                    }

                }
            } 
        }

    }
}
