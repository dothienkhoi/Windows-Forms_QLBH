using DAL.Models;
using DAL.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SanPhamSver
    {
        Pro131BhdtContext _context;
        public SanPhamSver()
        {
            _context = new Pro131BhdtContext();
        }
        public List<SanPham> GetAllProducts()
        {  // Get all
            return _context.SanPhams.ToList();
        }
        public string CreateSp(SanPham sanpham)
        {
            // Validate các thuộc tính
            if (sanpham.TenSanPham.Trim() == "" || sanpham.MoTaSanPham.Trim() == "" || sanpham.XuatXu.Trim() == "")
            {
                return "Hãy kiểm tra lại dữ liệu không được trống";
            }
            else if (sanpham.Gia < 0 || sanpham.SoLuongCon < 0)
            {
                return "Giá hoặc số lượng không thể là giá trị âm";
            }
            else if (string.IsNullOrEmpty(sanpham.HinhAnh))
            {
                return "Đường dẫn ảnh đang trống";
            }
            else
            {
                try
                {
                    _context.SanPhams.Add(sanpham);
                    _context.SaveChanges();
                    return "Thêm mới sản phẩm thành công";
                }
                catch (Exception e)
                {
                    return "Thêm thất bại " + e.Message;
                }
            }
        }
        public List<SanPham> SearchByName(string name) // Tìm những sản phẩm mà tên có chứa sản phẩm như thế
        {
            return _context.SanPhams.Where(p => p.TenSanPham.ToLower().Contains(name.ToLower())).ToList();
            // ToLower => Chuyển về dạng viết thường để tìm kiếm hoa thường đều được
        }
        public string LockSp(Guid id)
        {
            var sanPham = _context.SanPhams.Find(id);
            if (sanPham.TrangThai == 0) return "Sản phẩm đã bị khóa, không thể khóa";
            else
            {
                sanPham.TrangThai = 0;
                _context.SanPhams.Update(sanPham);
                _context.SaveChanges();
                return "Khóa sản phẩm thành công";
            }
        }
        public string UnLockSp(Guid id)
        {
            var product = _context.SanPhams.Find(id);
            if (product.TrangThai != 0) return "Sản phẩm không bị khóa, không thể mở khóa";
            else
            {
                product.TrangThai = 1;
                _context.SanPhams.Update(product);
                _context.SaveChanges();
                return "Khóa sản phẩm thành công";
            }
        }
        public string UpdateSP(SanPham sanphams, Guid id)
        {
            try
            {
                var updateProduct = _context.SanPhams.Find(id);
                if (updateProduct == null)
                {
                    return "ko tìm thấy";
                }

                updateProduct.TenSanPham = sanphams.TenSanPham;
                updateProduct.MoTaSanPham = sanphams.MoTaSanPham;
                updateProduct.HinhAnh = sanphams.HinhAnh;
                updateProduct.XuatXu = sanphams.XuatXu;
                updateProduct.Gia = sanphams.Gia;
                updateProduct.SoLuongCon = sanphams.SoLuongCon;
                updateProduct.TrangThai = sanphams.TrangThai;
                updateProduct.MaKhuyenMai = sanphams.MaKhuyenMai; // cập nhật mã khuyến mãi

                _context.SanPhams.Update(updateProduct);
                _context.SaveChanges();
                return "Sửa thành công";
            }
            catch (Exception ex)
            {
                return "Ko thể update: " + ex.Message;
            }
        }
        public string DeleteSp(Guid id)
        {
            var deletesp = _context.SanPhams.Find(id);
            if (deletesp == null)
            {
                return "Không tìm thấy mã sp";
            }
            else
            {
                _context.SanPhams.Remove(deletesp);
                _context.SaveChanges();
                return "Xóa Thành Công";

            }
        }
    }
}
