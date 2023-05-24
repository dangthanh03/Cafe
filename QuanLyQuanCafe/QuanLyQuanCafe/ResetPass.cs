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
    public partial class ResetPass : Form
    {
        private event EventHandler login;
        public event EventHandler Login
        {
            add { login += value; }
            remove { login -= value; }
        }
        private int id;
        private string name;
        public ResetPass(int id , string name)
        {
            this.Id = id;
            this.Name1 = name;
            InitializeComponent();
        }

        public int Id { get => id; set => id = value; }
        public string Name1 { get => name; set => name = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OldPassInput.Text.Equals( AccDAO.Instance.GetPass( Id) ) )
            {
             if(AccDAO.Instance.CheckAccForUpdate(name, OldPassInput.Text, NewPassInput.Text))
                {
                    MessageBox.Show("Đã cập nhật mật khẩu thành công");
                   
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau");

                }
            }
            else
            {
                MessageBox.Show("Mật khẩu chưa đúng, hãy thử lại");
            }
        }
    }
}
