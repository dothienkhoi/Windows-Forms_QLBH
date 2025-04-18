using BUS.Services;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using PRL.View;
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
    public partial class SanPhamfrm : Form
    {
        Pro131BhdtContext _context;
        Main _parentForm;
        KhachHangSver _khachHangSver;
        SanPhamSver _phamSver;
        SaleSver _saleSver;
        VoucherSver _voucherSver;
        HoaDonSver _hdsver;
        ChiTietHoaDonSver _hiTietHoaDonSver;
        List<SanPham> _sanPhams;
        List<HoaDon> _hoaDons;
        List<KhachHang> _khachHangs;

        public SanPhamfrm(Main parentForm)
        {
            _context = new Pro131BhdtContext();
            _parentForm = parentForm;
            _phamSver = new SanPhamSver();
            _saleSver = new SaleSver();
            _voucherSver = new VoucherSver();
            _hdsver = new HoaDonSver();
            _hiTietHoaDonSver = new ChiTietHoaDonSver();
            _khachHangSver = new KhachHangSver();
            InitializeComponent();
        }
        public void ReloadForm()
        {
            _parentForm.LoadSanPhamForm();
        }

        public Panel CreateSP(SaleSanPham sp)
        {
            PictureBox ptb_Img = new PictureBox();
            Label lb_Name = new Label();
            Label lb_Gia = new Label();
            Label lb_Giamoi = new Label();
            Label lb_Giavalue = new Label();
            Label lb_mota = new Label();
            Label lb_soluong = new Label();
            Label lb_xuatxu = new Label();
            Label lb_Sl_value = new Label();
            TextBox txt_SlBan = new TextBox();
            Button btn_mua = new Button();

            // Setting properties for controls
            ptb_Img.Location = new Point(12, 12);
            ptb_Img.Name = "ptb_Img";
            ptb_Img.Size = new Size(202, 232);
            ptb_Img.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_Img.ImageLocation = sp.HinhAnh;

            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_Name.Location = new Point(234, 9);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(45, 25);
            lb_Name.Text = sp.TenSP;

            lb_Gia.AutoSize = true;
            lb_Gia.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_Gia.Location = new Point(234, 45);
            lb_Gia.Name = "lb_Gia";
            lb_Gia.Size = new Size(78, 25);
            lb_Gia.Text = "Gia Ban";

            lb_Giamoi.AutoSize = true;
            lb_Giamoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_Giamoi.Location = new Point(234, 81);
            lb_Giamoi.Name = "lb_Giamoi";
            lb_Giamoi.Size = new Size(72, 25);
            lb_Giamoi.Text = sp.GiaSale.ToString();

            lb_Giavalue.AutoSize = true;
            lb_Giavalue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_Giavalue.Location = new Point(234, 113);
            lb_Giavalue.Name = "lb_Giavalue";
            lb_Giavalue.Size = new Size(52, 25);
            lb_Giavalue.Text = sp.Gia.ToString();
            lb_Giavalue.Font = new Font(lb_Giavalue.Font, FontStyle.Strikeout);

            lb_mota.AutoSize = true;
            lb_mota.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_mota.Location = new Point(26, 267);
            lb_mota.Name = "lb_mota";
            lb_mota.Size = new Size(62, 25);
            lb_mota.Text = sp.MoTa;

            lb_soluong.AutoSize = true;
            lb_soluong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_soluong.Location = new Point(234, 145);
            lb_soluong.Name = "lb_soluong";
            lb_soluong.Size = new Size(92, 25);
            lb_soluong.Text = "So luong ";

            lb_xuatxu.AutoSize = true;
            lb_xuatxu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_xuatxu.Location = new Point(26, 316);
            lb_xuatxu.Name = "lb_xuatxu";
            lb_xuatxu.Size = new Size(78, 25);
            lb_xuatxu.Text = sp.XuatXu;

            lb_Sl_value.AutoSize = true;
            lb_Sl_value.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_Sl_value.Location = new Point(234, 184);
            lb_Sl_value.Name = "lb_Sl_value";
            lb_Sl_value.Size = new Size(52, 25);
            lb_Sl_value.Text = sp.Soluongcon.ToString();

            txt_SlBan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txt_SlBan.Location = new Point(233, 232);
            txt_SlBan.Name = "txt_SlBan";
            txt_SlBan.PlaceholderText = "Nhap so luong mua";
            txt_SlBan.Size = new Size(176, 31);

            btn_mua.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_mua.Location = new Point(252, 285);
            btn_mua.Name = "btn_mua";
            btn_mua.Size = new Size(131, 47);
            btn_mua.Text = "Mua";
            btn_mua.UseVisualStyleBackColor = true;
            btn_mua.Click += Btn_mua_Click;

            // Add controls to panel
            Panel pn = new Panel();
            pn.Name = sp.Id.ToString();
            pn.Size = new Size(435, 370);

            pn.Controls.Add(txt_SlBan);
            pn.Controls.Add(btn_mua);
            pn.Controls.Add(lb_Giavalue);
            pn.Controls.Add(lb_mota);
            pn.Controls.Add(lb_Sl_value);
            pn.Controls.Add(lb_soluong);
            pn.Controls.Add(lb_xuatxu);
            pn.Controls.Add(lb_Gia);
            pn.Controls.Add(lb_Name);
            pn.Controls.Add(ptb_Img);
            pn.Controls.Add(lb_Giamoi);

            return pn;
        }

        private void Btn_mua_Click(object? sender, EventArgs e)
        {
            long price = 0;
            int amount = 0;
            int currentStock = 0;
            string ten = "";

            // Lấy thông tin của panel chứa SP
            Button btnMua = sender as Button;
            Panel cpnSP = btnMua.Parent as Panel;

            // Lấy danh sách Label và TextBox trong Panel ra
            List<Label> labels = new List<Label>();
            List<TextBox> textboxs = new List<TextBox>();
            foreach (var item in cpnSP.Controls)
            {
                if (item is Label) labels.Add(item as Label);
                if (item is TextBox) textboxs.Add(item as TextBox);
            }

            // Lấy giá mới và số lượng còn lại từ các Label
            foreach (var item in labels)
            {
                if (item.Name == "lb_Giamoi")
                {
                    price = Convert.ToInt64(item.Text);
                }
                if (item.Name == "lb_Sl_value")
                {
                    currentStock = Convert.ToInt32(item.Text);
                }
            }

            // Lấy số lượng mua từ TextBox
            foreach (var item in textboxs)
            {
                if (item.Name == "txt_SlBan")
                {
                    if (!int.TryParse(item.Text, out amount))
                    {
                        MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                }
            }
            foreach (var item in labels)
            {
                if(item.Name == "lb_Name")
                {
                    ten = item.Text;
                }
            }


            // Kiểm tra nếu số lượng mua vượt quá số lượng hiện có
            if (amount > currentStock)
            {
                MessageBox.Show("Không đủ số lượng để mua.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Guid productId = Guid.Parse(cpnSP.Name);
           
            Guid billId;
            if (Guid.TryParse(lb_mahdvalue.Text, out billId))
            {
                // Kiểm tra xem billId có phải là Guid.Empty hay không
                if (billId == Guid.Empty)
                {
                    MessageBox.Show("Vui lòng chọn mã hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _hiTietHoaDonSver = new ChiTietHoaDonSver();
            _hiTietHoaDonSver.AddToBill(billId, productId, price, amount);
            LoadHDCT(Guid.Parse(lb_mahdvalue.Text));
        }
        public void LoadProductByPage(int page) // Load sản phẩm theo trang, mỗi trang 4 sp
        {
            tableLayoutPanel_sp.Controls.Clear();
            _sanPhams = _phamSver.GetAllProducts(); // Lấy ra tất cả SP
            _saleSver = new SaleSver();
            var sales = _saleSver.GetAll();
            // Join để lấy data
            var saleProducts =
                from product in _sanPhams
                join sale in sales
                on product.MaKhuyenMai equals sale.MaKhuyenMai
                select new SaleSanPham
                {
                    Id = product.MaSanPham,
                    TenSP = product.TenSanPham,
                    MoTa = product.MoTaSanPham,
                    HinhAnh = product.HinhAnh,
                    XuatXu = product.XuatXu,
                    Gia = product.Gia,
                    Soluongcon = product.SoLuongCon,
                    TrangThai = product.TrangThai,
                    GiaSale = Convert.ToInt64(product.Gia - product.Gia * (sale.PhanTramGiam / 100))
                };
            // Khi có danh sách sản phẩm ta kiểm tra xem page có vi phạm không
            if (page * 4 - 4 < saleProducts.ToList().Count)
            {
                SaleSanPham sp = saleProducts.ToList()[page * 4 - 4];
                Panel p1 = CreateSP(sp);
                tableLayoutPanel_sp.Controls.Add(p1, 0, 0);
            }
            if (page * 4 - 3 < saleProducts.ToList().Count)
            {
                SaleSanPham sp = saleProducts.ToList()[page * 4 - 3];
                Panel p2 = CreateSP(sp);
                tableLayoutPanel_sp.Controls.Add(p2, 0, 1);
            }
            if (page * 4 - 2 < saleProducts.ToList().Count)
            {
                SaleSanPham sp = saleProducts.ToList()[page * 4 - 2];
                Panel p3 = CreateSP(sp);
                tableLayoutPanel_sp.Controls.Add(p3, 1, 0);
            }
            if (page * 4 - 1 < saleProducts.ToList().Count)
            {
                SaleSanPham sp = saleProducts.ToList()[page * 4 - 1];
                Panel p4 = CreateSP(sp);
                tableLayoutPanel_sp.Controls.Add(p4, 1, 1);
            }
            // Để xử lý Join không ra kết quả chúng ta có thể tạo 1 bản ghi sale 0% cho những cái nào ko sale
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_sotrang.Text) >= 2)
            {
                lb_sotrang.Text = Convert.ToInt32(lb_sotrang.Text) - 1 + "";
                LoadProductByPage(Convert.ToInt32(lb_sotrang.Text));
            }
        }

        private void lb_next_Click(object sender, EventArgs e)
        {
            var products = _phamSver.GetAllProducts();
            int count = products.Count;
            if (Convert.ToInt32(lb_sotrang.Text) < count / 4 && count % 4 == 0
                || Convert.ToInt32(lb_sotrang.Text) <= count / 4 && count % 4 != 0)
            {
                lb_sotrang.Text = Convert.ToInt32(lb_sotrang.Text) + 1 + "";
                LoadProductByPage(Convert.ToInt32(lb_sotrang.Text));
            }
        }

        private void SanPhamfrm_Load(object sender, EventArgs e)
        {
            LoadProductByPage(1);
            LoadPhone();
            
            LoadHinhThuc();
            LoadToDataGridview();
            ////
            comboBox_phone.SelectedIndex = -1;
            combobx_voucher.SelectedIndex = -1;
            comboBox_hinhthuctt.SelectedIndex = -1;

        }
        public void LoadHDCT(Guid billId)
        {
            dataGridView_hdct.Rows.Clear();
            var allDatas = _hiTietHoaDonSver.GetByid(billId);

            // Cấu hình cột cho DataGridView
            dataGridView_hdct.Columns.Clear();
            dataGridView_hdct.Columns.Add("MaChiTiet", "Mã Chi Tiết");
            dataGridView_hdct.Columns.Add("MaHoaDon", "Mã Hóa Đơn");
            dataGridView_hdct.Columns.Add("MaSanPham", "Mã Sản Phẩm");
            dataGridView_hdct.Columns.Add("GiaSanPham", "Giá Sản Phẩm");
            dataGridView_hdct.Columns.Add("SoLuong", "Số Lượng");

            foreach (var data in allDatas)
            {
                dataGridView_hdct.Rows.Add(data.MaChiTiet, data.MaHoaDon, data.MaSanPham, data.GiaSanPham, data.SoLuong);
            }
        }
        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_phone.SelectedIndex < 0) return;

            var selectedPhone = comboBox_phone.SelectedValue.ToString();
            var selectedKhachHang = _context.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == selectedPhone);

            if (selectedKhachHang != null)
            {
                txt_tenkh.Text = selectedKhachHang.TenKhachHang + "-" + selectedKhachHang.SoDienThoai;
            }
        }

        private void datagr_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                try
                {
                    DataGridViewRow row = datagr_hoadon.Rows[e.RowIndex];
                    lb_mahdvalue.Text = row.Cells[0].Value.ToString();
                    lb_tongtien.Text = row.Cells[1].Value.ToString();
                    lb_tongtienmoi.Text=row.Cells[7].Value.ToString();// thêm dòng này nếu ko cần thì xóa phục vụ cho view
                    //txt_motasp.Text = row.Cells[2].Value.ToString();
                    if (row.Cells[3].Value != null && !string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
                    {
                        string phone = row.Cells[3].Value.ToString();
                        comboBox_phone.SelectedValue = phone;
                    }
                    else
                    {
                        combobx_voucher.SelectedIndex = -1;
                    }
                    if (row.Cells[6].Value != null && !string.IsNullOrEmpty(row.Cells[6].Value.ToString()))
                    {
                        string mavoucher = row.Cells[6].Value.ToString();
                        combobx_voucher.SelectedValue = mavoucher;
                    }
                    else
                    {
                        combobx_voucher.SelectedIndex = -1;
                    }
                    LoadHDCT(Guid.Parse(lb_mahdvalue.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting product: " + ex.Message);
                }
            }
        }
        private void comboBox_phone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_phone.SelectedIndex < 0) return;

            var selectedPhone = comboBox_phone.SelectedValue.ToString();
            var selectedKhachHang = _context.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == selectedPhone);

            if (selectedKhachHang != null)
            {
                txt_tenkh.Text = selectedKhachHang.TenKhachHang + "-" + selectedKhachHang.SoDienThoai;
                txt_phone.Text = selectedKhachHang.SoDienThoai;
                LoadVoucher(txt_phone.Text);
            }
        }

        private void comboBox_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addhd_Click(object sender, EventArgs e)
        {
            string accountId = "";
            if (_parentForm != null)
            {
                var label = _parentForm.Controls.Find("label_acc", true).FirstOrDefault() as Label;
                if (label != null)
                {
                    accountId = label.Text;
                }
                else
                {
                    MessageBox.Show("Label with name 'label_acc' not found.");
                    return;
                }

                // Lấy mã voucher từ combobx_voucher
                string voucherid = combobx_voucher.SelectedValue?.ToString();
                if (!string.IsNullOrEmpty(voucherid))
                {
                    // Kiểm tra giá trị trước khi tạo hóa đơn
                    if (string.IsNullOrEmpty(accountId))
                    {
                        MessageBox.Show("Account ID không hợp lệ.");
                        return;
                    }
                    if (string.IsNullOrEmpty(comboBox_phone.Text))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ.");
                        return;
                    }
                    HoaDon hoaDon = new HoaDon()
                    {
                        MaHoaDon = Guid.NewGuid(),
                        TrangThai = 0,
                        TongTien = 0,
                        MaTaiKhoan = accountId,
                        SoDienThoaiKhachHang = comboBox_phone.Text,
                        NgayTao = DateTime.Now,
                        MaVoucher = voucherid,
                    };
                    _hdsver = new HoaDonSver();
                    string result = _hdsver.CreateHD(hoaDon);
                    MessageBox.Show(result);
                    if (result == "Tạo thành công")
                    {
                        LoadToDataGridview();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn mã voucher hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Parent form not set.");
            }
        }
        private void LoadPhone()
        {
            var phoneList = _context.KhachHangs.Select(kh => new { kh.TenKhachHang, kh.SoDienThoai }).ToList();
            comboBox_phone.DataSource = phoneList;
            comboBox_phone.DisplayMember = "SoDienThoai";
            comboBox_phone.ValueMember = "SoDienThoai";
        }
        private void LoadVoucher(string customerPhoneNumber)
        {
            try
            {
                var voucherList = _voucherSver.GetVouchersByCustomerPhoneNumber(customerPhoneNumber)
                                                  .Where(v => v.TrangThai == 1) // Lọc các voucher có trạng thái hoạt động
                                                  .Select(v => new { v.MaVoucher, v.TenVoucher })
                                                  .ToList();

                if (voucherList.Any())
                {
                    combobx_voucher.DataSource = voucherList;
                    combobx_voucher.DisplayMember = "TenVoucher"; // Hiển thị tên voucher
                    combobx_voucher.ValueMember = "MaVoucher"; // Giá trị là mã voucher
                }
                else
                {
                    combobx_voucher.DataSource = null;
                    MessageBox.Show("Không có voucher nào hoạt động cho khách hàng này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải voucher: {ex.Message}");
            }
        }
        private void LoadToDataGridview()
        {
            _hoaDons = _hdsver.GetAllHoaDon(); // Lấy ra tất cả hóa đơn
            _voucherSver = new VoucherSver();
            var vouchers = _voucherSver.GetAllVouchers(); // Lấy ra tất cả voucher

            // Join để lấy data
            var voucherhoadons =
                from hoadon in _hoaDons
                join voucher in vouchers
                on hoadon.MaVoucher equals voucher.MaVoucher into hv
                from voucher in hv.DefaultIfEmpty() // Đảm bảo join với tất cả hóa đơn, kể cả không có voucher
                select new HoadonView
                {
                    Id = hoadon.MaHoaDon,
                    TongTien = hoadon.TongTien,
                    MaTaiKhoan = hoadon.MaTaiKhoan,
                    SoDienThoaiKhachHang = hoadon.SoDienThoaiKhachHang,
                    NgayTao = hoadon.NgayTao,
                    TrangThai = hoadon.TrangThai,
                    MaVoucher = hoadon.MaVoucher,
                    TongTienMoi = voucher == null ? hoadon.TongTien :
                                   Convert.ToInt64(hoadon.TongTien - (hoadon.TongTien * (voucher.GiaTriGiam / 100.0)))
                };

            datagr_hoadon.Rows.Clear();
            var allDatas = voucherhoadons.ToList().Where(hd => hd.TrangThai == 0).ToList();
            datagr_hoadon.ColumnCount = 8;
            datagr_hoadon.Columns[0].Name = "MaHoaDon";
            datagr_hoadon.Columns[1].Name = "TongTien";
            datagr_hoadon.Columns[2].Name = "MaTaiKhoan";
            datagr_hoadon.Columns[3].Name = "SoDienThoaiKhachHang";
            datagr_hoadon.Columns[4].Name = "NgayTao";
            datagr_hoadon.Columns[5].Name = "TrangThai";
            datagr_hoadon.Columns[6].Name = "MaVoucher";
            datagr_hoadon.Columns[7].Name = "TongTienMoi";

            // Thêm dữ liệu
            foreach (var data in allDatas)
            {
                datagr_hoadon.Rows.Add(data.Id, data.TongTien, data.MaTaiKhoan, data.SoDienThoaiKhachHang, data.NgayTao, data.TrangThai, data.MaVoucher, data.TongTienMoi);
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(lb_mahdvalue.Text);
            string reslut = _hdsver.DeleteHD(id);
            MessageBox.Show(reslut);
            LoadToDataGridview();
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            lb_mahdvalue.Text = "";
            lb_tongtien.Text = "";
            comboBox_phone.SelectedIndex = -1;
            combobx_voucher.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            LoadHDCT(Guid.Parse(lb_mahdvalue.Text));
        }
        private void dataGridView_hdct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid _selectedBillID;
            Guid _selectedProductID;
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView_hdct.Rows[e.RowIndex];
                if (selectedRow.Cells["MaHoaDon"] != null && selectedRow.Cells["MaSanPham"] != null)
                {
                    _selectedBillID = (Guid)selectedRow.Cells["MaHoaDon"].Value;
                    _selectedProductID = (Guid)selectedRow.Cells["MaSanPham"].Value;

                    MessageBox.Show($"Đã chọn MaHoaDon: {_selectedBillID}, MaSanPham: {_selectedProductID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cột MaHoaDon hoặc MaSanPham không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void lb_tinhtongtienhdct_Click(object sender, EventArgs e)
        {
            if (dataGridView_hdct.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_hdct.SelectedRows[0];
                if (selectedRow != null)
                {
                    Guid billID;
                    if (selectedRow.Cells["MaHoaDon"].Value != null)
                    {
                        billID = (Guid)selectedRow.Cells["MaHoaDon"].Value;
                    }
                    else
                    {
                        MessageBox.Show("Cột MaHoaDon không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    _hiTietHoaDonSver.UpdateTotalAmount(billID);

                    MessageBox.Show("Cập nhật tổng số tiền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHDCT(billID);
                    LoadToDataGridview();
                    ReloadForm();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật tổng số tiền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_hoantra_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
            "Bạn có chắc chắn muốn hoàn trả không?",
            "Xác nhận ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                if (dataGridView_hdct.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView_hdct.SelectedRows[0];
                    if (selectedRow != null)
                    {
                        Guid billDetailID = (Guid)selectedRow.Cells["MaChiTiet"].Value;
                        Guid productID = (Guid)selectedRow.Cells["MaSanPham"].Value;
                        Guid billID = (Guid)selectedRow.Cells["MaHoaDon"].Value;
                        var chiTietHoaDonSver = new ChiTietHoaDonSver();
                        string result = chiTietHoaDonSver.RefundProduct(billDetailID, productID);

                        MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadHDCT(billID);
                        _hiTietHoaDonSver.HoanlaItongtien(billDetailID, billID, productID);
                        LoadProductByPage(1);
                        LoadToDataGridview();
                        ReloadForm();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một dòng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để hoàn trả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
            "Bạn có chắc chắn muốn thanh toán không?",
            "Xác nhận ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                if (!long.TryParse(txt_sotien.Text, out long amountPaid))
                {
                    MessageBox.Show("Số tiền không hợp lệ. Vui lòng kiểm tra lại.");
                    return;
                }

                if (dataGridView_hdct.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần thanh toán.");
                    return;
                }

                var maHoaDon = (Guid)dataGridView_hdct.SelectedRows[0].Cells["MaHoaDon"].Value;
                var hoaDon = _hdsver.GetAllHoaDon().FirstOrDefault(hd => hd.MaHoaDon == maHoaDon);
                if (hoaDon == null)
                {
                    MessageBox.Show("Hóa đơn không tồn tại.");
                    return;
                }

                var totalAmount = (long)datagr_hoadon.SelectedRows[0].Cells["TongTienMoi"].Value;
                if (amountPaid < totalAmount)
                {
                    MessageBox.Show("Số tiền thanh toán không đủ.");
                    return;
                }

                // Lấy mã hình thức thanh toán từ ComboBox
                if (comboBox_hinhthuctt.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn hình thức thanh toán.");
                    return;
                }
                Guid maHinhThuc = (Guid)comboBox_hinhthuctt.SelectedValue;

                var statusUpdateResult = _hdsver.UpdateHoaDonStatus(maHoaDon, 1);

                // Cập nhật số lượng sản phẩm và xóa chi tiết hóa đơn
                var thanhToanResult = _hiTietHoaDonSver.ThanhToanHoaDon(maHoaDon, amountPaid, totalAmount);

                if (thanhToanResult == "Thanh toán thành công.")
                {
                    var historyResult = _hdsver.CreateLsthanhtoan(maHoaDon, maHinhThuc, amountPaid, totalAmount);
                    MessageBox.Show(historyResult);
                }
                else
                {
                    MessageBox.Show(thanhToanResult);
                }

                // Cập nhật lại DataGridView
                LoadToDataGridview();
                LoadHDCT(Guid.Parse(lb_mahdvalue.Text));
            }
        }
        private void LoadHinhThuc()
        {
            try
            {
                var voucherList = _context.HinhThucThanhToans.Where(km => km.TrangThai == 1) .Select(km => new { km.MaHinhThuc, km.TenHinhThuc }).ToList();
                if (voucherList.Any())
                {
                    comboBox_hinhthuctt.DataSource = voucherList;
                    comboBox_hinhthuctt.DisplayMember = "TenHinhThuc";
                    comboBox_hinhthuctt.ValueMember = "MaHinhThuc"; 
                }
                else
                {
                    comboBox_hinhthuctt.DataSource = null;
                    MessageBox.Show("Không có hình thức nào hoạt động.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải hình thức: {ex.Message}");
            }
        }
        
    }
}