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
    public partial class Main : Form
    {
        string accountInfor;
        public Main(string accountInfo)
        {
            InitializeComponent();
            this.accountInfor = accountInfo;
        }
        public void LoadSanPhamForm()
        {
            // Tạo instance của SanPhamfrm và truyền tham chiếu đến MainForm nếu cần
            SanPhamfrm sanPhamfrm = new SanPhamfrm(this);

            // Hiển thị form SanPhamfrm trong panel_mainshow
            LoadFormIntoPanel(sanPhamfrm);
        }
        private void LoadFormIntoPanel(Form form)
        {
            // Dọn dẹp panel trước khi thêm form mới
            panel_mainshow.Controls.Clear();

            // Thiết lập form con
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            // Thêm form con vào panel
            panel_mainshow.Controls.Add(form);
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string[] infor = accountInfor.Split(':'); // Cắt role và username ra để xử lý
            label_acc.Text = infor[1];
            if (infor[0] == "2") // Nếu role == 2 tức là nhân viên thì không hiển thị các nút quản lý
            {
                btn_QLkh.Visible = false;
                btn_qlvoucher.Visible = false;
                btn_QLSP.Visible = false;
                btn_qlkm.Visible = false;
                button9.Visible = false;
                button8.Visible = false;


            }
        }

        private void btn_qlkm_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            SaleFrm saleFrm = new SaleFrm();
            saleFrm.TopLevel = false;
            panel_mainshow.Controls.Add(saleFrm);
            saleFrm.FormBorderStyle = FormBorderStyle.None;
            saleFrm.Show();
        }

        private void btn_QLkh_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            QuanLyKhachHangfrm quanLyKhachHangfrm = new QuanLyKhachHangfrm();
            quanLyKhachHangfrm.TopLevel = false;
            panel_mainshow.Controls.Add(quanLyKhachHangfrm);
            quanLyKhachHangfrm.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            TaiKhoanFrm taiKhoanFrm = new TaiKhoanFrm();
            taiKhoanFrm.TopLevel = false;
            panel_mainshow.Controls.Add(taiKhoanFrm);
            taiKhoanFrm.Show();
            taiKhoanFrm.FormBorderStyle = FormBorderStyle.None;

        }

        private void btn_qlvoucher_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            Voucherfrm voufrm = new Voucherfrm();
            voufrm.TopLevel = false;
            panel_mainshow.Controls.Add(voufrm);
            voufrm.Show();
            voufrm.FormBorderStyle = FormBorderStyle.None;

        }

        private void button_hinhthucthanhtoan_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            HinhThucTTFrm hinhThucTTFrm = new HinhThucTTFrm();
            hinhThucTTFrm.TopLevel = false;
            panel_mainshow.Controls.Add(hinhThucTTFrm);
            hinhThucTTFrm.Show();
            hinhThucTTFrm.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            HoaDonFrm hoaDonFrm = new HoaDonFrm();
            hoaDonFrm.TopLevel = false;
            panel_mainshow.Controls.Add(hoaDonFrm);
            hoaDonFrm.Show();
            hoaDonFrm.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            QuaLYSPfrm quaLYSPfrm = new QuaLYSPfrm();
            quaLYSPfrm.TopLevel = false;
            panel_mainshow.Controls.Add(quaLYSPfrm);
            quaLYSPfrm.Show();
            quaLYSPfrm.FormBorderStyle = FormBorderStyle.None;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btn_lstt_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            LichSuTTFrm lichSuTTFrm = new LichSuTTFrm();
            lichSuTTFrm.TopLevel = false;
            panel_mainshow.Controls.Add(lichSuTTFrm);
            lichSuTTFrm.Show();
            lichSuTTFrm.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_xemsp_Click(object sender, EventArgs e)
        {
            //panel_mainshow.Controls.Clear();
            //SanPhamfrm sanPhamfrm = new SanPhamfrm(this); // cái này cần truyền tham số gì 
            //sanPhamfrm.TopLevel = false;
            //panel_mainshow.Controls.Add(sanPhamfrm);
            //sanPhamfrm.Show();
            //sanPhamfrm.FormBorderStyle = FormBorderStyle.None;
            LoadSanPhamForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            HoadonchiTietFrm hoadonchiTietFrm = new HoadonchiTietFrm();
            hoadonchiTietFrm.TopLevel = false;
            panel_mainshow.Controls.Add(hoadonchiTietFrm);
            hoadonchiTietFrm.Show();
            hoadonchiTietFrm.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_doidiem_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            DoiDiemFrm doiDiemFrm = new DoiDiemFrm();
            doiDiemFrm.TopLevel = false;
            panel_mainshow.Controls.Add(doiDiemFrm);
            doiDiemFrm.Show();
            doiDiemFrm.FormBorderStyle = FormBorderStyle.None;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel_mainshow.Controls.Clear();
            ThongKeFrm thongKeDoanhThuFrm = new ThongKeFrm();
            thongKeDoanhThuFrm.TopLevel = false;
            panel_mainshow.Controls.Add(thongKeDoanhThuFrm);
            thongKeDoanhThuFrm.Show();
            thongKeDoanhThuFrm.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
