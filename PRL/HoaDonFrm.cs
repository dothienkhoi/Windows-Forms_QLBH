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
using OfficeOpenXml;
using System.IO;

namespace PRL
{
    public partial class HoaDonFrm : Form
    {
        HoaDonSver _donSver;
        public HoaDonFrm()
        {
            _donSver = new HoaDonSver();
            InitializeComponent();
        }

        private void dataGridView_hoadonf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView_hoadonf.Rows[e.RowIndex];
                txt_mahdf.Text = row.Cells[0].Value.ToString();
                txt_tongtienf.Text = row.Cells[1].Value.ToString();
                txt_matkf.Text = row.Cells[2].Value.ToString();
                txt_sdtf.Text = row.Cells[3].Value.ToString();
                dtime_hoadon.Value = Convert.ToDateTime(row.Cells[4].Value);
                comboBox_trangthaif.SelectedIndex = Convert.ToInt32((row.Cells[5].Value.ToString()));
                comboBox_voucher.SelectedValue = Convert.ToInt32((row.Cells[5].Value.ToString()));


            }
        }
        private void LoadToDataGridview()
        {
            dataGridView_hoadonf.Rows.Clear();
            var allDatas = _donSver.GetAllHoaDon();
            dataGridView_hoadonf.ColumnCount = 7;
            dataGridView_hoadonf.Columns[0].HeaderText = "Mã Hóa đơn";
            dataGridView_hoadonf.Columns[1].HeaderText = "Tổng Tiền";
            dataGridView_hoadonf.Columns[2].HeaderText = "Mã Tài Khoản";
            dataGridView_hoadonf.Columns[3].HeaderText = "Phone";
            dataGridView_hoadonf.Columns[4].HeaderText = "Ngày Tạo";
            dataGridView_hoadonf.Columns[5].HeaderText = "Trạng Thái";
            dataGridView_hoadonf.Columns[6].HeaderText = "Mã VouCher";
            foreach (var data in allDatas)
            {
                dataGridView_hoadonf.Rows.Add(data.MaHoaDon, data.TongTien, data.MaTaiKhoan, data.SoDienThoaiKhachHang, data.NgayTao, data.TrangThai, data.MaVoucher);
            }
        }

        private void HoaDonFrm_Load(object sender, EventArgs e)
        {
            LoadToDataGridview();
        }

        private void btn_close_hdf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_hdf_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txt_mahdf.Text);
            string reslut = _donSver.DeleteHD(id);
            MessageBox.Show(reslut);
            LoadToDataGridview();
        }

        private void txt_lstt_sreach_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_lstt_sreach.Text.ToLower();
            var allDatas = _donSver.GetAllHoaDon();

            var filteredData = allDatas.Where(kh => kh.SoDienThoaiKhachHang.ToLower().Contains(searchValue)).ToList();
            dataGridView_hoadonf.Rows.Clear();
            foreach (var data in allDatas)
            {
                dataGridView_hoadonf.Rows.Add(data.MaHoaDon, data.TongTien, data.MaTaiKhoan, data.SoDienThoaiKhachHang, data.NgayTao, data.TrangThai, data.MaVoucher);
            }
        }

        private void btn_xuatexcel_Click(object sender, EventArgs e)
        {
            if (dataGridView_hoadonf.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thiết lập LicenseContext cho EPPlus
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Lấy dòng được chọn
            DataGridViewRow selectedRow = dataGridView_hoadonf.SelectedRows[0];

            // Tạo một SaveFileDialog để người dùng chọn đường dẫn lưu file Excel
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = "HoaDon_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Tạo một file Excel mới
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // Thêm một worksheet mới
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("HoaDon");

                        // Thêm tiêu đề cột
                        for (int i = 0; i < dataGridView_hoadonf.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataGridView_hoadonf.Columns[i].HeaderText;
                        }

                        // Thêm dữ liệu của dòng được chọn vào worksheet
                        for (int i = 0; i < dataGridView_hoadonf.Columns.Count; i++)
                        {
                            worksheet.Cells[2, i + 1].Value = selectedRow.Cells[i].Value;
                        }

                        // Lưu file Excel
                        FileInfo fileInfo = new FileInfo(sfd.FileName);
                        excelPackage.SaveAs(fileInfo);

                        // Mở file Excel ngay sau khi lưu
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = fileInfo.FullName,
                            UseShellExecute = true
                        });
                    }

                    MessageBox.Show("Xuất dữ liệu thành công và mở file Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clear_hd_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txt_mahdf.Text = "";
            txt_matkf.Text = "";
            txt_sdtf.Text = "";
            txt_tongtienf.Text = "";
            comboBox_trangthaif.SelectedIndex = -1;
            comboBox_voucher.SelectedIndex = -1;
        }

        private void txt_mahdf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
