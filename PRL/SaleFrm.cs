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
    public partial class SaleFrm : Form
    {
        SaleRepo saleRepo;
        public SaleFrm()
        {
            saleRepo = new SaleRepo();
            InitializeComponent();
        }

        private void btn_close_vou_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_km_sreach_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_km_sreach.Text.ToLower();
            var allDatas = saleRepo.GetAllKmai();

            var filteredData = allDatas.Where(kh => kh.TenKhuyenMai.ToLower().Contains(searchValue)).ToList();
            dataGridView_km.Rows.Clear();
            foreach (var data in allDatas)
            {
                dataGridView_km.Rows.Add(data.MaKhuyenMai, data.TenKhuyenMai, data.MoTaKhuyenMai, data.PhanTramGiam, data.NgayBatDau, data.NgayKetThuc, data.TrangThai);
            }
        }

        private void btnadd_vou_Click(object sender, EventArgs e)
        {

            var khuyenMai = new KhuyenMai
            {
                MaKhuyenMai = Guid.NewGuid(),
                TenKhuyenMai = txt_tenkm.Text,
                MoTaKhuyenMai = txt_motakm.Text,
                PhanTramGiam = Convert.ToDouble(txt_giatrigiam_km.Text),
                NgayBatDau = ngaybatdau_datetime_km.Value,
                NgayKetThuc = dateTime_endtime_km.Value,
                TrangThai = comboBox_trthai_km.SelectedIndex,
            };

            string result = saleRepo.CreateSale(khuyenMai);
            MessageBox.Show(result);
            LoadDataToGridView();
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
                Guid id = Guid.Parse(txt_makm.Text);
                var khuyenMai = new KhuyenMai
                {
                    MaKhuyenMai = Guid.NewGuid(),
                    TenKhuyenMai = txt_tenkm.Text,
                    MoTaKhuyenMai = txt_motakm.Text,
                    PhanTramGiam = Convert.ToDouble(txt_giatrigiam_km.Text),
                    NgayBatDau = ngaybatdau_datetime_km.Value,
                    NgayKetThuc = dateTime_endtime_km.Value,
                    TrangThai = comboBox_trthai_km.SelectedIndex,
                };

                string result = saleRepo.UpdateSale(khuyenMai, id);
                MessageBox.Show(result);
                LoadDataToGridView();
            }
        }

        private void btn_delete_vou_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
            "Bạn có chắc chắn muốn cập nhật thông tin không?",
            "Xác nhận ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Guid id = Guid.Parse(txt_makm.Text);
                string result = saleRepo.DeleteSale(id);
                MessageBox.Show(result);
                LoadDataToGridView();
            }

                
        }

        private void clear_vou_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridView_km_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView_km.Rows[e.RowIndex]; 
                txt_makm.Text = row.Cells[0].Value.ToString(); 
                txt_tenkm.Text = row.Cells[1].Value.ToString(); 
                txt_motakm.Text = row.Cells[2].Value.ToString(); 
                txt_giatrigiam_km.Text = row.Cells[3].Value.ToString(); 
                ngaybatdau_datetime_km.Value = Convert.ToDateTime(row.Cells[4].Value); // Cập nhật dateTimePicker với giá trị cột Ngày Bắt Đầu
                dateTime_endtime_km.Value = Convert.ToDateTime(row.Cells[5].Value); // Cập nhật dateTimePicker với giá trị cột Ngày Kết Thúc
                comboBox_trthai_km.SelectedIndex = Convert.ToInt32((row.Cells[6].Value.ToString())); // Cập nhật comboBox với giá trị cột Trạng Thái
            }
        }

        private void SaleFrm_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            dataGridView_km.Rows.Clear();
            var allDatas = saleRepo.GetAllKmai();
            dataGridView_km.ColumnCount = 7;
            dataGridView_km.Columns[0].HeaderText = "Mã Khuyến Mãi";
            dataGridView_km.Columns[1].HeaderText = "Tên Khuyễn Mãi";
            dataGridView_km.Columns[2].HeaderText = "Mô Tả";
            dataGridView_km.Columns[3].HeaderText = "Phần Trăm Giảm";
            dataGridView_km.Columns[4].HeaderText = "Ngày Bắt Dầu";
            dataGridView_km.Columns[5].HeaderText = "Ngày Kết Thúc";
            dataGridView_km.Columns[6].HeaderText = "Trạng Thái";
            foreach (var data in allDatas)
            {
                dataGridView_km.Rows.Add(data.MaKhuyenMai, data.TenKhuyenMai, data.MoTaKhuyenMai, data.PhanTramGiam, data.NgayBatDau, data.NgayKetThuc, data.TrangThai);
            }
        }
        public void ClearForm()
        {
            txt_makm.Text = "";
            txt_tenkm.Text = "";
            txt_motakm.Text = "";
            txt_giatrigiam_km.Text = "";
            ngaybatdau_datetime_km.Value = DateTime.Now;
            dateTime_endtime_km.Value = DateTime.Now;
            comboBox_trthai_km.SelectedIndex = -1;
        }
    }
}
