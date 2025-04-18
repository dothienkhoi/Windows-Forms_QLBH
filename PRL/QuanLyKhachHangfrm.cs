using BUS.Services;
using DAL.Models;
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
    public partial class QuanLyKhachHangfrm : Form
    {
        KhachHangSver hangSver;
        public QuanLyKhachHangfrm()
        {
            hangSver = new KhachHangSver();
            InitializeComponent();
        }

        private void QuanLyKhachHangfrm_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void dataGridView_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView_kh.Rows[e.RowIndex]; // Lấy ra dòng mà mình được chọn
                txt_sdt.Text = row.Cells[0].Value.ToString(); // Cập nhật textBox_maVL với giá trị cột MaVL
                txt_tenkh.Text = row.Cells[1].Value.ToString(); // Cập nhật textBox_tenVL với giá trị cột TenVL
                txt_diemtichluy.Text = row.Cells[2].Value.ToString(); // Cập nhật textBox_tenVL với giá trị cột TenVL
            }
        }
        public void LoadDataToGridView()
        {
            dataGridView_kh.Rows.Clear();
            var allDatas = hangSver.GetAll();
            dataGridView_kh.ColumnCount = 3;
            dataGridView_kh.Columns[0].HeaderText = "Số điện Thoại";
            dataGridView_kh.Columns[1].HeaderText = "Tên Khách Hàng";
            dataGridView_kh.Columns[2].HeaderText = "Điểm Tích Lũy";
            foreach (var data in allDatas)
            {
                dataGridView_kh.Rows.Add(data.SoDienThoai, data.TenKhachHang, data.DiemTichLuy);
            }
        }

        public void ClearForm()
        {
            txt_diemtichluy.Text = "";
            txt_sdt.Text = "";
            textBox1.Text = "";
            txt_tenkh.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sdt = txt_sdt.Text;
            string tenkh = txt_tenkh.Text;
            int diemtichluy;
            if (string.IsNullOrEmpty(txt_sdt.Text) || string.IsNullOrEmpty(txt_tenkh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txt_diemtichluy.Text, out diemtichluy ))
            {
                MessageBox.Show("Điểm tích lũy phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ///int diemtichluy = Convert.ToInt32(txt_diemtichluy.Text);
            KhachHang khachHang = new KhachHang()
            {
                SoDienThoai = sdt,
                TenKhachHang = tenkh,
                DiemTichLuy = diemtichluy,
            };

            MessageBox.Show(hangSver.Create(khachHang));
            LoadDataToGridView();
            ClearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sdt = txt_sdt.Text.Trim();
                string tenkh = txt_tenkh.Text.Trim();
                int diemtichluy;

                if (string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(tenkh))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txt_diemtichluy.Text.Trim(), out diemtichluy))
                {
                    MessageBox.Show("Điểm tích lũy phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                KhachHang khachHang = new KhachHang()
                {
                    SoDienThoai = sdt,
                    TenKhachHang = tenkh,
                    DiemTichLuy = diemtichluy,
                };
                string result = hangSver.Update(khachHang, sdt);

                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToGridView();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sdt = txt_sdt.Text;
            MessageBox.Show(hangSver.Delete(sdt));
            LoadDataToGridView();
            ClearForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.ToLower();
            var allDatas = hangSver.GetAll();

            var filteredData = allDatas.Where(kh => kh.SoDienThoai.ToLower().Contains(searchValue)).ToList();
            dataGridView_kh.Rows.Clear();
            foreach (var data in filteredData)
            {
                dataGridView_kh.Rows.Add(data.SoDienThoai, data.TenKhachHang, data.DiemTichLuy);
            }
        }
    }
}
