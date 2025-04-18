using BUS.Services;
using DAL.Models;
using DAL.repositories;
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
    public partial class HinhThucTTFrm : Form
    {
        HinhThucTTSver _htttsever;
        public HinhThucTTFrm()
        {
            _htttsever = new HinhThucTTSver();
            InitializeComponent();
        }

        private void btnadd_lstt_Click(object sender, EventArgs e)
        {
            string tenhttt = txt_tenhttt.Text;
            int role = comboBox_trangthaihttt.SelectedIndex; // Selected index mặc định là -1
            if (string.IsNullOrEmpty(tenhttt))
            {
                MessageBox.Show("Dữ liệu sai, hãy kiểm tra lại");
            }
            else
            {
                // DialogResult là kết quả cho một hộp thoại chứa câu hỏi Yes/No/Cancel,...
                DialogResult result = MessageBox.Show("Bạn muốn thêm chứ?", "Thêm tài khoản", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var hinhthuc = new HinhThucThanhToan
                    {
                        MaHinhThuc = Guid.NewGuid(),
                        TenHinhThuc = txt_tenhttt.Text,
                        TrangThai = comboBox_trangthaihttt.SelectedIndex,
                    };
                    string thobao = _htttsever.CreateLichSuThanhToan(hinhthuc);
                    MessageBox.Show(thobao);
                    LoadDataToGridView();

                }
            }
        }

        private void btn_update_httt_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận
            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn cập nhật thông tin không?",
                "Xác nhận ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu người dùng chọn Yes, thực hiện cập nhật
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    Guid id = Guid.Parse(txt_malhttt.Text);
                    var hinhthuc = new HinhThucThanhToan
                    {
                        MaHinhThuc = Guid.NewGuid(), // Bạn có thể cần sửa đoạn này nếu MaHinhThuc không phải là mới
                        TenHinhThuc = txt_tenhttt.Text,
                        TrangThai = comboBox_trangthaihttt.SelectedIndex,
                    };

                    string result = _htttsever.UpdateLichSuThanhToan(hinhthuc, id);
                    MessageBox.Show(result);
                    LoadDataToGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_delete_httt_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa  thông tin không?",
                "Xác nhận ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirmResult == DialogResult.Yes)
            {
                Guid id = Guid.Parse(txt_malhttt.Text);
                string result = _htttsever.DeleteLichSuThanhToan(id);
                MessageBox.Show(result);
                LoadDataToGridView();
            } 
        }

        private void clear_httt_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            dataGridView_httt.Rows.Clear();
            var allDatas = _htttsever.GetAllHinhThucThanhToans();
            dataGridView_httt.ColumnCount = 3;
            dataGridView_httt.Columns[0].HeaderText = "Mã Hình Thức";
            dataGridView_httt.Columns[1].HeaderText = "Tên Hình Thức";
            dataGridView_httt.Columns[2].HeaderText = "Trạng Thái";
            foreach (var data in allDatas)
            {
                dataGridView_httt.Rows.Add(data.MaHinhThuc, data.TenHinhThuc, data.TrangThai);
            }
        }

        public void ClearForm()
        {
            txt_tenhttt.Text = "";
            txt_malhttt.Text = "";
            comboBox_trangthaihttt.SelectedIndex = -1;
        }

        private void btn_close_httt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_httt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView_httt.Rows[e.RowIndex];
                txt_malhttt.Text = row.Cells[0].Value.ToString();
                txt_tenhttt.Text = row.Cells[1].Value.ToString();
                comboBox_trangthaihttt.SelectedIndex = Convert.ToInt32(row.Cells[2].Value);
            }
        }

        private void HinhThucTTFrm_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
    }
}
