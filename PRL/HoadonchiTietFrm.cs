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

namespace PRL
{
    public partial class HoadonchiTietFrm : Form
    {
        ChiTietHoaDonSver _chiTietHoaDon;
        public HoadonchiTietFrm()
        {
            _chiTietHoaDon = new ChiTietHoaDonSver();
            InitializeComponent();
        }

        private void HoadonchiTietFrm_Load(object sender, EventArgs e)
        {
            LoadToDataGridview();
        }
        private void LoadToDataGridview()
        {
            dataGridView_hoadonCTf.Rows.Clear();
            var allDatas = _chiTietHoaDon.GetALLHDCT();
            dataGridView_hoadonCTf.ColumnCount = 5;
            dataGridView_hoadonCTf.Columns[0].HeaderText = "Mã Chi Tiết";
            dataGridView_hoadonCTf.Columns[1].HeaderText = "Mã Hóa đơn";
            dataGridView_hoadonCTf.Columns[2].HeaderText = "Mã Sản Phẩm";
            dataGridView_hoadonCTf.Columns[3].HeaderText = "Giá Sản Phẩm";
            dataGridView_hoadonCTf.Columns[4].HeaderText = "Số Lượng";

            foreach (var data in allDatas)
            {
                dataGridView_hoadonCTf.Rows.Add(data.MaChiTiet, data.MaHoaDon, data.MaSanPham, data.GiaSanPham, data.SoLuong);
            }
        }

        private void dataGridView_hoadonCTf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_hoadonCTf.Rows[e.RowIndex];
                txt_mact.Text = row.Cells[0].Value.ToString();
                txt_mahd_ct.Text = row.Cells[1].Value.ToString();
                txt_masp_ct.Text = row.Cells[2].Value.ToString();
                txt_giasp_ct.Text = row.Cells[3].Value.ToString();
                txt_soluong_ct.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btn_delete_hdctf_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa chi tiết không?",
                "Xác nhận ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirmResult == DialogResult.Yes)
            {
                Guid id = Guid.Parse(txt_mact.Text);
                string result = _chiTietHoaDon.DeleteBillDetail(id);
                MessageBox.Show(result);
                LoadToDataGridview();
            }
        }

        private void btn_close_hdctf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Clear()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
