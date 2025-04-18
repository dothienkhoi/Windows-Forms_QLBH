using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repositories
{
    public class LichSuThanhToanrepo
    {
        Pro131BhdtContext _context;
        public LichSuThanhToanrepo()
        {
            _context = new Pro131BhdtContext();
        }
        public List<LichSuThanhToan> GetAllLichSuThanhToans()
        {
            return _context.LichSuThanhToans.ToList();
        }

        public LichSuThanhToan GetLichSuThanhToanById(Guid id)
        {
            return _context.LichSuThanhToans.Find(id);
        }

        public string CreateLichSuThanhToan(LichSuThanhToan lichSu)
        {
            try
            {
                _context.LichSuThanhToans.Add(lichSu);
                _context.SaveChanges();
                return "Tạo mới lịch sử thanh toán thành công";
            }
            catch (Exception)
            {
                return "Lỗi khi tạo mới lịch sử thanh toán";
            }
        }

        public string UpdateLichSuThanhToan(LichSuThanhToan lichSu)
        {
            var existingLichSu = _context.LichSuThanhToans.Find(lichSu.MaLichSu);
            if (existingLichSu == null)
            {
                return "Lịch sử thanh toán không tồn tại";
            }

            existingLichSu.MaHoaDon = lichSu.MaHoaDon;
            existingLichSu.MaHinhThuc = lichSu.MaHinhThuc;
            existingLichSu.SoTien = lichSu.SoTien;
            existingLichSu.GhiChu = lichSu.GhiChu;

            try
            {
                _context.SaveChanges();
                return "Cập nhật lịch sử thanh toán thành công";
            }
            catch (Exception)
            {
                return "Lỗi khi cập nhật lịch sử thanh toán";
            }
        }

        public string DeleteLichSuThanhToan(Guid id)
        {
            var lichSu = _context.LichSuThanhToans.Find(id);
            if (lichSu == null)
            {
                return "Lịch sử thanh toán không tồn tại";
            }

            try
            {
                _context.LichSuThanhToans.Remove(lichSu);
                _context.SaveChanges();
                return "Xóa lịch sử thanh toán thành công";
            }
            catch (Exception)
            {
                return "Lỗi khi xóa lịch sử thanh toán";
            }
        }
    }
}
