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

namespace PRL
{
    public partial class LichSuTTFrm : Form
    {
        LichSuTTSver _tTSver;
        HoaDonSver _hoaDonSver;
        public LichSuTTFrm()
        {
            _tTSver = new LichSuTTSver();
            _hoaDonSver = new HoaDonSver();
            InitializeComponent();
        }


        private void btn_delete_lstt_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txt_malstt.Text);
            if (id == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string reslut = _tTSver.DeleteLichSuThanhToan(id);
            MessageBox.Show(reslut);
            LoadToDataGridview();
        }

        private void clear_lstt_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            txt_ghichu_ls.Text = "";
            txt_mahdf.Text = "";
            txt_mahtf.Text = "";
            txt_sotien_ls.Text = "";
            txt_malstt.Text = "";
        }
        private void btn_close_lstt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_lstt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView_lstt.Rows[e.RowIndex];
                Guid maLichSu = (Guid)row.Cells[0].Value;
                Guid maHOADON = (Guid)row.Cells[1].Value; // Thay đổi chỉ số ô nếu cần

                // Lấy thông tin chi tiết từ cơ sở dữ liệu
                var lichSuThanhToan = _tTSver.GetAllLichSuThanhToans()
                    .FirstOrDefault(ls => ls.MaLichSu == maLichSu);
                var hoadontongtien = _hoaDonSver.GetAllHoaDon()
                    .FirstOrDefault(hd => hd.MaHoaDon == maHOADON);

                if (lichSuThanhToan != null && hoadontongtien != null)
                {
                    txt_malstt.Text = lichSuThanhToan.MaLichSu.ToString();
                    txt_mahdf.Text = lichSuThanhToan.MaHoaDon.ToString();
                    txt_mahtf.Text = lichSuThanhToan.MaHinhThuc.ToString();
                    string sotiendathanhtoan = $"Số tiền khách đã thanh toán: {hoadontongtien.TongTien}";
                    txt_sotien_ls.Text = sotiendathanhtoan;

                    // Tạo chuỗi ghi chú với thông tin đầy đủ

                    string ghiChu = $"Số tiền khách đưa: {lichSuThanhToan.SoTien}, Số tiền cần trả: {lichSuThanhToan.SoTien - hoadontongtien.TongTien}";
                    txt_ghichu_ls.Text = ghiChu;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cần thiết.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadToDataGridview()
        {
            dataGridView_lstt.Rows.Clear();
            var allDatas = _tTSver.GetAllLichSuThanhToans();
            dataGridView_lstt.ColumnCount = 5;
            dataGridView_lstt.Columns[0].HeaderText = "Mã Lịch sử";
            dataGridView_lstt.Columns[1].HeaderText = "Mã Hóa Đơn";
            dataGridView_lstt.Columns[2].HeaderText = "Mã Hình Thức";
            dataGridView_lstt.Columns[3].HeaderText = "Số Tiền";
            dataGridView_lstt.Columns[4].HeaderText = "Ghi Chú";
            foreach (var data in allDatas)
            {
                dataGridView_lstt.Rows.Add(data.MaLichSu, data.MaHoaDon, data.MaHinhThuc, data.SoTien, data.GhiChu);
            }
        }

        private void LichSuTTFrm_Load(object sender, EventArgs e)
        {
            LoadToDataGridview();
        }

        private void btn_xuatexcells_Click(object sender, EventArgs e)
        {
            if (dataGridView_lstt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thiết lập LicenseContext cho EPPlus
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Lấy dòng được chọn
            DataGridViewRow selectedRow = dataGridView_lstt.SelectedRows[0];

            // Tạo một SaveFileDialog để người dùng chọn đường dẫn lưu file Excel
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = "LichSuThanhToan_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Tạo một file Excel mới
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // Thêm một worksheet mới
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("LichSuThanhToan");

                        // Thêm tiêu đề cột
                        for (int i = 0; i < dataGridView_lstt.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataGridView_lstt.Columns[i].HeaderText;
                        }

                        // Thêm dữ liệu của dòng được chọn vào worksheet
                        for (int i = 0; i < dataGridView_lstt.Columns.Count; i++)
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

    }
}
