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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL
{
    public partial class TaiKhoanFrm : Form
    {
        TaiKhoanServices taiKhoanServices;
        public TaiKhoanFrm()
        {
            taiKhoanServices = new TaiKhoanServices();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_tk_Click(object sender, EventArgs e)
        {
            string username = txt_tentk.Text;
            string password = txt_mk.Text;
            int role = comboBox_role.SelectedIndex; // Selected index mặc định là -1
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || role == -1)
            {
                MessageBox.Show("Dữ liệu sai, hãy kiểm tra lại");
            }
            else
            {
                // DialogResult là kết quả cho một hộp thoại chứa câu hỏi Yes/No/Cancel,...
                DialogResult result = MessageBox.Show("Bạn muốn thêm chứ?", "Thêm tài khoản", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string message = taiKhoanServices.CreateAccount(username, password, role);
                    MessageBox.Show(message);
                    LoadDataToGridView();
                }
            }
        }

        private void btn_update_tk_Click(object sender, EventArgs e)
        {

            string username = txt_tentk.Text;
            string password = txt_mk.Text;
            int role = comboBox_role.SelectedIndex; // Selected index mặc định là -1
            MessageBox.Show(taiKhoanServices.UpdateAccount(username, password, role));
            LoadDataToGridView();
        }

        private void btn_delete_tk_Click(object sender, EventArgs e)
        {
            string username = txt_tentk.Text;
            string mess = taiKhoanServices.DeleteAccount(username);
            MessageBox.Show(mess);
            LoadDataToGridView();

        }

        private void clear_tk_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_khoa_tk_Click(object sender, EventArgs e)
        {
            string username = txt_tentk.Text;
            string message = taiKhoanServices.LockAccount(username);
            MessageBox.Show(message);
            LoadDataToGridView();
        }

        private void btn_mokhoa_tk_Click(object sender, EventArgs e)
        {
            string username = txt_tentk.Text;
            string message = taiKhoanServices.UnLockAccount(username);
            MessageBox.Show(message);
            LoadDataToGridView();
        }

        private void TaiKhoanFrm_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            dataGridView_taik.Rows.Clear();
            var allDatas = taiKhoanServices.GetAccounts();
            dataGridView_taik.ColumnCount = 3;
            dataGridView_taik.Columns[0].HeaderText = "Tên Tài Khoản";
            dataGridView_taik.Columns[1].HeaderText = "Mật Khẩu";
            dataGridView_taik.Columns[2].HeaderText = "Vai Trò";
            foreach (var data in allDatas)
            {
                dataGridView_taik.Rows.Add(data.TenDangNhap, data.MatKhau, data.VaiTro);
            }
        }

        public void ClearForm()
        {
            txt_tentk.Text = "";
            txt_mk.Text = "";
            comboBox_role.SelectedIndex = -1;
        }

        private void btn_close_tk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_tk_sreach_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox_tk_sreach.Text.ToLower();
            var allDatas = taiKhoanServices.GetAccounts();

            var filteredData = allDatas.Where(kh => kh.TenDangNhap.ToLower().Contains(searchValue)).ToList();
            dataGridView_taik.Rows.Clear();
            foreach (var data in filteredData)
            {
                dataGridView_taik.Rows.Add(data.TenDangNhap, data.MatKhau, data.VaiTro);
            }
        }

        private void dataGridView_taik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView_taik.Rows[e.RowIndex]; // Lấy ra dòng mà mình được chọn
                txt_tentk.Text = row.Cells[0].Value.ToString(); // Cập nhật textBox_maVL với giá trị cột MaVL
                txt_mk.Text = row.Cells[1].Value.ToString(); // Cập nhật textBox_tenVL với giá trị cột TenVL
                comboBox_role.SelectedIndex = Convert.ToInt32(row.Cells[2].Value) ; // Cập nhật textBox_tenVL với giá trị cột TenVL
            }
        }
    }
}
