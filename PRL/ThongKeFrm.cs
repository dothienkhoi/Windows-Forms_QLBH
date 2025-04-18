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
    public partial class ThongKeFrm : Form
    {
        Pro131BhdtContext _context;
        HoaDonSver _hoadonSver;
        public ThongKeFrm()
        {
            _context = new Pro131BhdtContext();
            _hoadonSver = new HoaDonSver();
            InitializeComponent();
        }

        private void btb_thongke_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTime.Now.Date; // Thay đổi ngày hiện tại nếu cần

            // Thống kê doanh thu theo ngày
            long doanhThuNgay = _context.HoaDons
                .Where(hd => hd.NgayTao.Date == selectedDate)
                .Sum(hd => hd.TongTien);
            lb_dt_ngay_value.Text = $"{doanhThuNgay:N0} VND";

            // Thống kê doanh thu theo tháng
            DateTime firstDayOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            long doanhThuThang = _context.HoaDons
                .Where(hd => hd.NgayTao >= firstDayOfMonth && hd.NgayTao <= lastDayOfMonth)
                .Sum(hd => hd.TongTien);
            lb_dt_thang_value.Text = $"{doanhThuThang:N0} VND";

            // Thống kê số khách hàng theo ngày
            var soKhachHang = _context.HoaDons
                .Where(hd => hd.NgayTao.Date == selectedDate)
                .Select(hd => hd.SoDienThoaiKhachHang)
                .Distinct()
                .Count();
            lb_sokh_value.Text = $"{soKhachHang}";
            LoadToDataGridview();
        }
        private void LoadToDataGridview()
        {
            dataGridView_hdtk.Rows.Clear();
            var allDatas = _hoadonSver.GetAllHoaDon();
            dataGridView_hdtk.ColumnCount = 4;
            dataGridView_hdtk.Columns[0].HeaderText = "Mã Hóa đơn";
            dataGridView_hdtk.Columns[1].HeaderText = "Tổng Tiền";
            dataGridView_hdtk.Columns[2].HeaderText = "Phone";
            dataGridView_hdtk.Columns[3].HeaderText = "Ngày Tạo";
            foreach (var data in allDatas)
            {
                dataGridView_hdtk.Rows.Add(data.MaHoaDon, data.TongTien,  data.SoDienThoaiKhachHang, data.NgayTao);
            }
        }
    }
}
