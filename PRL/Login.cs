using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class Login : Form
    {
        TaiKhoanServices khoanServices;
        public Login()
        {
            khoanServices = new TaiKhoanServices();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_pass.Text;
            string accountInfor = khoanServices.Login(username, password);
            if (string.IsNullOrEmpty(accountInfor))
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            else if (accountInfor.Split(':')[0] == "0") // Cắt ra để lấy role, nếu = 0 tức là tài khoản đã bị khóa
            {
                MessageBox.Show("Tài khoản của bạn đã bị khóa, vui lòng kiểm tra xem đã bị đuổi việc chưa?");
            }
            else
            {
                Main main = new Main(accountInfor); // Tạo form main truyền account infor qua
                main.Show();
                this.Hide();
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
