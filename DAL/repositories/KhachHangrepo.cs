using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repositories
{
    public class KhachHangrepo
    {
        Pro131BhdtContext _context;
        public KhachHangrepo()
        {
            _context = new Pro131BhdtContext();
        }
        public List<KhachHang> GetAll()
        {
            return _context.KhachHangs.ToList(); // Lấy ra danh sách toàn bộ sản phẩm
        }
        public KhachHang GetById(string sdt)
        {
            return _context.KhachHangs.Find(sdt); // Phương thức Find(id) chỉ áp dụng khi id là khóa chính
        }
        public bool CreateKH(KhachHang khach)
        {
            try
            {
                _context.KhachHangs.Add(khach); _context.SaveChanges(); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Sửa sản phẩm
        public bool UpdateKh(KhachHang khach, string sdt)
        {
            try
            {
                // Lấy ra đối tượng cần sửa
                var updateItem = _context.KhachHangs.Find(sdt); // chỉ dùng với khóa chính
                updateItem.SoDienThoai = khach.SoDienThoai;
                updateItem.TenKhachHang = khach.TenKhachHang;
                updateItem.DiemTichLuy = khach.DiemTichLuy;
                _context.KhachHangs.Update(updateItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool DeleteKH(string sdt)
        {
            try
            {
                var deleteitem = _context.KhachHangs.Find(sdt);
                _context.KhachHangs.Remove(deleteitem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
