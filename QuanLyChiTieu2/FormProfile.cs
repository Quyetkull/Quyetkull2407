using QuanLyChiTieu2.DAO;
using QuanLyChiTieu2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu2
{
    public partial class FormProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public FormProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            //textBoxUserName.Text = LoginAccount.UserName;
            //textBoxDisplayName.Text = LoginAccount.DisplayName;
        }

        void UpdateAccount()
        {
            string displayName = textBoxDisplayName.Text;
            string password = textBoxPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string nhaplaiPassword = textBoxnhậplạiPassword.Text;
            string userName = textBoxUserName.Text;

            if(!newPassword.Equals(nhaplaiPassword))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
            }
            else 
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newPassword))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền lại đúng mật khẩu");
                }    
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main = new FormMain();
            main.Show();
        }
    }
}
