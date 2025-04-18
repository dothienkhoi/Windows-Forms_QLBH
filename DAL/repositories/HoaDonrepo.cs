using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repositories
{
    public class HoaDonrepo
    {
        Pro131BhdtContext _context;
        public HoaDonrepo()
        {
            _context = new Pro131BhdtContext();
        }
        public List<HoaDon> GetAllHoaDons()
        {
            return _context.HoaDons.ToList();
        }

        public HoaDon GetHoaDonById(Guid id)
        {
            return _context.HoaDons.Find(id);
        }
        public string CreateHoaDon(HoaDon hoaDon)
        {
            try
            {
                _context.HoaDons.Add(hoaDon);
                _context.SaveChanges();
                return "Tạo mới hóa đơn thành công";
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                return "Lỗi khi tạo mới hóa đơn: " + ex.Message;
            }
        }
        public string UpdateHoaDon(HoaDon hoaDon, Guid id)
        {
            var existingHoaDon = _context.HoaDons.Find(id);
            if (existingHoaDon == null)
            {
                return "Hóa đơn không tồn tại";
            }

            try
            {
                existingHoaDon.TongTien = hoaDon.TongTien;
                existingHoaDon.MaTaiKhoan = hoaDon.MaTaiKhoan;
                existingHoaDon.SoDienThoaiKhachHang = hoaDon.SoDienThoaiKhachHang;
                existingHoaDon.NgayTao = hoaDon.NgayTao;
                existingHoaDon.TrangThai = hoaDon.TrangThai;
                existingHoaDon.MaVoucher = hoaDon.MaVoucher;

                _context.SaveChanges();
                return "Cập nhật hóa đơn thành công";
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                return "Lỗi khi cập nhật hóa đơn: " + ex.Message;
            }
        }
        public string DeleteHoaDon(Guid id)
        {
            var hoaDon = _context.HoaDons.Find(id);
            if (hoaDon == null)
            {
                return "Hóa đơn không tồn tại";
            }

            try
            {
                _context.HoaDons.Remove(hoaDon);
                _context.SaveChanges();
                return "Xóa hóa đơn thành công";
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                return "Lỗi khi xóa hóa đơn: " + ex.Message;
            }
        }

    }
}
