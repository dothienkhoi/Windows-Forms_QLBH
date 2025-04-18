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
    public partial class Voucherfrm : Form
    {
        VoucherSver voucherSver;
        public Voucherfrm()
        {
            voucherSver = new VoucherSver();
            InitializeComponent();
        }

        private void txt_vou_sreach_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_vou_sreach.Text.ToLower();
            var allDatas = voucherSver.GetAllVouchers();

            // Lọc dữ liệu dựa trên giá trị tìm kiếm
            var filteredData = allDatas.Where(voucher => voucher.TenVoucher.ToLower().Contains(searchValue)).ToList();

            // Xóa các hàng hiện tại trong DataGridView
            dataGridView_mavou.Rows.Clear();

            // Thêm các dữ liệu đã lọc vào DataGridView
            foreach (var data in filteredData)
            {
                dataGridView_mavou.Rows.Add(data.MaVoucher, data.TenVoucher, data.MoTa, data.GiaTriGiam, data.NgayBatDau, data.NgayKetThuc, data.TrangThai);
            }

        }

        private void btnadd_vou_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_update_vou_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
            "Bạn có chắc chắn muốn cập nhật thông tin không?",
            "Xác nhận ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes) 
            {
                var voucher = new Voucher
                {
                    MaVoucher = txt_mavou.Text,
                    TenVoucher = txt_tenvou.Text,
                    MoTa = txt_motavou.Text,
                    GiaTriGiam = long.Parse(txt_giatrigiam.Text),
                    NgayBatDau = ngaybatdau_datetime.Value,
                    NgayKetThuc = dateTime_endtime.Value,
                    TrangThai = comboBox_trthai.SelectedIndex,
                };
                string result = voucherSver.UpdateVoucher(voucher);
                MessageBox.Show(result);
                LoadDataToGridView();
            }
            
        }

        private void btn_delete_vou_Click(object sender, EventArgs e)
        {
            
           
            var confirmResult = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa thông tin không?",
            "Xác nhận ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                string id = txt_mavou.Text;
                string result = voucherSver.DeleteVoucher(id);
                MessageBox.Show(result);
                LoadDataToGridView();
            }

               
        }

        private void clear_vou_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_close_vou_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView_mavou_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView_mavou.Rows[e.RowIndex]; // Lấy ra dòng mà mình được chọn
                txt_mavou.Text = row.Cells[0].Value.ToString(); // Cập nhật textBox_maVL với giá trị cột MaVL
                txt_tenvou.Text = row.Cells[1].Value.ToString(); // Cập nhật textBox_tenVL với giá trị cột TenVL
                txt_motavou.Text = row.Cells[2].Value.ToString(); // Cập nhật textBox_tenVL với giá trị cột TenVL
                txt_giatrigiam.Text = row.Cells[3].Value.ToString(); // Cập nhật textBox_tenVL với giá trị cột TenVL
                ngaybatdau_datetime.Value = Convert.ToDateTime(row.Cells[4].Value); // Cập nhật dateTimePicker với giá trị cột Ngày Bắt Đầu
                dateTime_endtime.Value = Convert.ToDateTime(row.Cells[5].Value); // Cập nhật dateTimePicker với giá trị cột Ngày Kết Thúc
                comboBox_trthai.SelectedIndex = Convert.ToInt32((row.Cells[6].Value.ToString())); // Cập nhật comboBox với giá trị cột Trạng Thái
            }
        }

        private void Voucherfrm_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            dataGridView_mavou.Rows.Clear();
            var allDatas = voucherSver.GetAllVouchers();
            dataGridView_mavou.ColumnCount = 7;
            dataGridView_mavou.Columns[0].HeaderText = "Mã Voucher";
            dataGridView_mavou.Columns[1].HeaderText = "Tên Voucher";
            dataGridView_mavou.Columns[2].HeaderText = "Mô Tả";
            dataGridView_mavou.Columns[3].HeaderText = "Giá Trị Giảm";
            dataGridView_mavou.Columns[4].HeaderText = "Ngày Bắt Dầu";
            dataGridView_mavou.Columns[5].HeaderText = "Ngày Kết Thúc";
            dataGridView_mavou.Columns[6].HeaderText = "Trạng Thái";
            foreach (var data in allDatas)
            {
                dataGridView_mavou.Rows.Add(data.MaVoucher, data.TenVoucher, data.MoTa, data.GiaTriGiam, data.NgayBatDau, data.NgayKetThuc, data.TrangThai);
            }
        }

            public void ClearForm()
            {
                txt_mavou.Text = "";
                txt_tenvou.Text = "";
                txt_motavou.Text = "";
                txt_giatrigiam.Text = "";
                ngaybatdau_datetime.Value = DateTime.Now;
                dateTime_endtime.Value = DateTime.Now;
                comboBox_trthai.SelectedIndex = -1;
            }
    }
}
