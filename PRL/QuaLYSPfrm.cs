using BUS.Services;
using DAL.Models;
using DAL.repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRL
{
    public partial class QuaLYSPfrm : Form
    {
        Pro131BhdtContext _context;
        SanPhamSver phamSver;
        SaleSver saleSver;
        public QuaLYSPfrm()
        {
            _context = new Pro131BhdtContext();
            InitializeComponent();
            phamSver = new SanPhamSver();
            saleSver = new SaleSver();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_sp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                try
                {
                    DataGridViewRow row = dataGridView_sp.Rows[e.RowIndex];
                    txt_masp.Text = row.Cells[0].Value.ToString();
                    txt_tensp.Text = row.Cells[1].Value.ToString();
                    txt_motasp.Text = row.Cells[2].Value.ToString();
                    ptb_hinhanhsp.ImageLocation = row.Cells[3].Value.ToString();
                    txt_xuatxusp.Text = row.Cells[4].Value.ToString();
                    txt_giasp.Text = row.Cells[5].Value.ToString();
                    txt_soluongconsp.Text = row.Cells[6].Value.ToString();
                    combox_trangthai.SelectedIndex = Convert.ToInt32(row.Cells[7].Value);

                    if (row.Cells[8].Value != null && !string.IsNullOrEmpty(row.Cells[8].Value.ToString()))
                    {
                        Guid maKhuyenMai = (Guid)row.Cells[8].Value;
                        combox_makm.SelectedValue = maKhuyenMai;
                    }
                    else
                    {
                        combox_makm.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting product: " + ex.Message);
                }
            }
        }

        private void ptb_hinhanhsp_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            ptb_hinhanhsp.ImageLocation = dialog.FileName;
        }

        private void btn_add_sp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thêm chứ?", "Thêm tài khoản", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SanPham sanpham = new SanPham()
                {
                    MaSanPham = Guid.NewGuid(),
                    TenSanPham = txt_tensp.Text,
                    XuatXu = txt_xuatxusp.Text,
                    MoTaSanPham = txt_motasp.Text,
                    Gia = Convert.ToInt64(txt_giasp.Text),
                    SoLuongCon = Convert.ToInt32(txt_soluongconsp.Text),
                    TrangThai = combox_trangthai.SelectedIndex,
                    HinhAnh = ptb_hinhanhsp.ImageLocation,
                    MaKhuyenMai = (Guid)combox_makm.SelectedValue,
                };
                MessageBox.Show(phamSver.CreateSp(sanpham));
                LoadDataToGridView();
            }
            
        }

        private void btn_update_sp_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
               "Bạn có chắc chắn muốn cập nhật sản phẩm không?",
               "Xác nhận ",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            { 
                Guid id = Guid.Parse(txt_masp.Text);
                if (id == null)
                {
                    MessageBox.Show("Bạn cần chọn sản phẩm cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SanPham sanpham = new SanPham()
                    {
                        MaSanPham = id,
                        TenSanPham = txt_tensp.Text,
                        XuatXu = txt_xuatxusp.Text,
                        MoTaSanPham = txt_motasp.Text,
                        Gia = Convert.ToInt64(txt_giasp.Text),
                        SoLuongCon = Convert.ToInt32(txt_soluongconsp.Text),
                        TrangThai = combox_trangthai.SelectedIndex,
                        HinhAnh = ptb_hinhanhsp.ImageLocation,
                        MaKhuyenMai = (Guid)combox_makm.SelectedValue // cập nhật mã khuyến mãi
                    };
                    string result = phamSver.UpdateSP(sanpham, id);
                    MessageBox.Show(result);
                    LoadDataToGridView();
                }
                
            }
            
        }

        private void btn_delete_sp_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
               "Bạn có chắc chắn muốn cập nhật thông tin không?",
               "Xác nhận ",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Guid id = Guid.Parse(txt_masp.Text);
                string reslut = phamSver.DeleteSp(id);
                MessageBox.Show(reslut);
                LoadDataToGridView();
            }
           

        }

        private void clear_sp_Click(object sender, EventArgs e)
        {
            ClearForm();

        }
        public void LoadDataToGridView()
        {
            dataGridView_sp.Rows.Clear();
            var allDatas = phamSver.GetAllProducts();
            dataGridView_sp.ColumnCount = 9;
            dataGridView_sp.Columns[0].HeaderText = "Mã Sản Phẩm";
            dataGridView_sp.Columns[1].HeaderText = "Tên Sản Phẩm";
            dataGridView_sp.Columns[2].HeaderText = "Mô Tả";
            dataGridView_sp.Columns[3].HeaderText = "Hình Ảnh";
            dataGridView_sp.Columns[4].HeaderText = "Xuất Xứ";
            dataGridView_sp.Columns[5].HeaderText = "Giá";
            dataGridView_sp.Columns[6].HeaderText = "Số Lượng còn";
            dataGridView_sp.Columns[7].HeaderText = "Trạng Thái";
            dataGridView_sp.Columns[8].HeaderText = "Mã Khuyến Mãi";
            foreach (var data in allDatas)
            {
                dataGridView_sp.Rows.Add(data.MaSanPham, data.TenSanPham, data.MoTaSanPham, data.HinhAnh, data.XuatXu, data.Gia, data.SoLuongCon, data.TrangThai, data.MaKhuyenMai);
            }
        }
        public void ClearForm()
        {
            txt_masp.Text = "";
            txt_tensp.Text = "";
            txt_motasp.Text = "";
            ptb_hinhanhsp.ImageLocation = "";
            txt_xuatxusp.Text = "";
            txt_giasp.Text = "";
            txt_soluongconsp.Text = "";
            combox_trangthai.SelectedIndex = -1;
            combox_makm.SelectedIndex = -1;
            txt_sp_sreach.Text = "";

        }

        private void QuaLYSPfrm_Load(object sender, EventArgs e)
        {

            LoadDataToGridView();
            LoadMaKhuyenMai();
            combox_makm.SelectedIndex = -1;
        }
        private void LoadMaKhuyenMai()
        {
            var maKhuyenMaiList = _context.KhuyenMais
                                          .Where(km => km.TrangThai == 1) // Lọc khuyến mãi có trạng thái hoạt động
                                          .Select(km => new { km.MaKhuyenMai, km.TenKhuyenMai })
                                          .ToList();
            combox_makm.DataSource = maKhuyenMaiList;
            combox_makm.DisplayMember = "TenKhuyenMai"; // Hiển thị tên khuyến mãi
            combox_makm.ValueMember = "MaKhuyenMai"; // Giá trị là mã khuyến mãi
        }

        private void btn_khoa_sp_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txt_masp.Text);
            string message = phamSver.LockSp(id);
            MessageBox.Show(message);
            LoadDataToGridView();
        }

        private void btn_mokhoa_sp_Click(object sender, EventArgs e)
        {

            Guid id = Guid.Parse(txt_masp.Text);
            string message = phamSver.UnLockSp(id);
            MessageBox.Show(message);
            LoadDataToGridView();
        }

        private void txt_sp_sreach_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_sp_sreach.Text.ToLower();
            var allDatas = phamSver.GetAllProducts();

            var filteredData = allDatas.Where(kh => kh.TenSanPham.ToLower().Contains(searchValue)).ToList();
            dataGridView_sp.Rows.Clear();
            foreach (var data in allDatas)
            {
                dataGridView_sp.Rows.Add(data.MaSanPham, data.TenSanPham, data.MoTaSanPham, data.HinhAnh, data.XuatXu, data.Gia, data.SoLuongCon, data.TrangThai, data.MaKhuyenMai);
            }
        }
    }
}
