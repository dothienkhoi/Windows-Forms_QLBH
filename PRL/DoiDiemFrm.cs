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
    public partial class DoiDiemFrm : Form
    {
        Pro131BhdtContext _context;
        DoiDiemsver _doiDiemsver;
        public DoiDiemFrm()
        {
            _context = new Pro131BhdtContext();
            _doiDiemsver = new DoiDiemsver();
            InitializeComponent();
        }

        private void DoiDiemFrm_Load(object sender, EventArgs e)
        {
            LoadToDataGridview();
            LoadKhachHang();
            comboBox_sdtkhdd.SelectedIndex = -1;
        }

        private void btndoi_vou_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu số điện thoại chưa được chọn hoặc textbox trống
            if (comboBox_sdtkhdd.SelectedIndex < 0 || string.IsNullOrEmpty(txt_diemcandoi.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng và nhập số điểm cần đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPhone = comboBox_sdtkhdd.SelectedValue.ToString();
            var selectedKhachHang = _context.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == selectedPhone);

            // Kiểm tra nếu khách hàng tồn tại
            if (selectedKhachHang == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int diemCanDoi;
            // Kiểm tra nếu số điểm cần đổi là số hợp lệ
            if (!int.TryParse(txt_diemcandoi.Text, out diemCanDoi) || diemCanDoi <= 0 && diemCanDoi >= 1000)
            {
                MessageBox.Show("Số điểm cần đổi không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi dịch vụ để thực hiện đổi điểm lấy voucher
            string maVoucher = txt_mavoucherdd.Text;
            string result = _doiDiemsver.DoiDiemLayVoucher(selectedPhone, diemCanDoi, maVoucher);

            if (result.StartsWith("Đổi điểm lấy voucher thành công"))
            {
                // Cập nhật điểm tích lũy của khách hàng
                string updateResult = _doiDiemsver.CapNhatDiemTichLuy(selectedPhone, diemCanDoi);

                if (updateResult.StartsWith("Cập nhật điểm tích lũy thành công"))
                {
                    MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại thông tin trên form
                    txt_tenkhdd.Text = selectedKhachHang.TenKhachHang;
                    txt_diemkhdd.Text = selectedKhachHang.DiemTichLuy.ToString();
                    txt_mavoucherdd.Text = maVoucher;
                    txt_diemcandoi.Text = string.Empty;

                    // Cập nhật lại DataGridView
                    LoadToDataGridview();
                }
                else
                {
                    MessageBox.Show(updateResult, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_doidiem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa thông tin không?",
            "Xác nhận ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txt_madoidiem.Text))
                {
                    MessageBox.Show("Vui lòng chọn một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Guid maDoiDiem;
                if (!Guid.TryParse(txt_madoidiem.Text, out maDoiDiem))
                {
                    MessageBox.Show("Mã đổi điểm không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi phương thức từ service để xóa đối tượng
                string result = _doiDiemsver.XoaDoiDiem(maDoiDiem);

                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại DataGridView
                LoadToDataGridview();
            }

        }

        private void dataGridView_doidiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView_doidiem.Rows[e.RowIndex];
                txt_madoidiem.Text = row.Cells[0].Value.ToString();
                if (row.Cells[1].Value != null && !string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                {
                    string phone = row.Cells[1].Value.ToString();
                    comboBox_sdtkhdd.SelectedValue = phone;
                }
                else
                {
                    comboBox_sdtkhdd.SelectedIndex = -1;
                }
                txt_mavoucherdd.Text = row.Cells[2].Value.ToString();
                dateTime_taodd.Value = Convert.ToDateTime(row.Cells[3].Value);
                txt_diemcandoi.Text = row.Cells[4].Value.ToString();
            }
        }
        private void LoadKhachHang()
        {
            comboBox_sdtkhdd.DataSource = _context.KhachHangs.ToList();
            comboBox_sdtkhdd.DisplayMember = "SoDienThoai";
            comboBox_sdtkhdd.ValueMember = "SoDienThoai";
        }
        private void LoadToDataGridview()
        {
            dataGridView_doidiem.Rows.Clear();
            var allDatas = _doiDiemsver.GetAllDoiDiem();
            dataGridView_doidiem.ColumnCount = 5;
            dataGridView_doidiem.Columns[0].HeaderText = "Mã Đổi Điểm";
            dataGridView_doidiem.Columns[1].HeaderText = "Số Điện Thoại";
            dataGridView_doidiem.Columns[2].HeaderText = "Mã Voucher";
            dataGridView_doidiem.Columns[3].HeaderText = "Ngày Đổi";
            dataGridView_doidiem.Columns[4].HeaderText = "Số Điểm đổi";
            foreach (var data in allDatas)
            {
                dataGridView_doidiem.Rows.Add(data.MaDoiDiem, data.SoDienThoaiKhachHang, data.MaVoucher, data.NgayDoi, data.SoDiem);
            }
        }

        private void comboBox_sdtkhdd_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_sdtkhdd.SelectedIndex < 0) return;

            var selectedPhone = comboBox_sdtkhdd.SelectedValue.ToString();
            var selectedKhachHang = _context.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == selectedPhone);

            if (selectedKhachHang != null)
            {
                txt_tenkhdd.Text = selectedKhachHang.TenKhachHang;
                txt_diemkhdd.Text = selectedKhachHang.DiemTichLuy.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void clear_doi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        public void ClearForm()
        {
            txt_madoidiem.Text = "";
            txt_diemcandoi.Text = "";
            txt_diemkhdd.Text = "";
            txt_mavoucherdd.Text = "";
            txt_tenkhdd.Text = "";
            txt_tenkhdd.Text = "";
        }

        private void txt_dd_sreach_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_dd_sreach.Text.ToLower();
            var allDatas = _doiDiemsver.GetAllDoiDiem();

            // Lọc dữ liệu dựa trên giá trị tìm kiếm
            var filteredData = allDatas.Where(voucher => voucher.SoDienThoaiKhachHang.ToLower().Contains(searchValue)).ToList();

            // Xóa các hàng hiện tại trong DataGridView
            dataGridView_doidiem.Rows.Clear();

            // Thêm các dữ liệu đã lọc vào DataGridView
            foreach (var data in allDatas)
            {
                dataGridView_doidiem.Rows.Add(data.MaDoiDiem, data.SoDienThoaiKhachHang, data.MaVoucher, data.NgayDoi, data.SoDiem);
            }
        }
    }
}
