using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repositories
{
    public class HinhThucTTrepo
    {
        Pro131BhdtContext _context;
        public HinhThucTTrepo()
        {
            _context = new Pro131BhdtContext();
        }
        public List<HinhThucThanhToan> GetAllHinhThucTT()
        {
            return _context.HinhThucThanhToans.ToList();
        }
        public HinhThucThanhToan GetidHinhThucTT(Guid id)
        {
            return _context.HinhThucThanhToans.Find(id);
        }
        public string CreateHthucThanhToan(HinhThucThanhToan thanhToan)
        {
            try
            {
                _context.HinhThucThanhToans.Add(thanhToan);
                _context.SaveChanges();
                return "Tạo mới hình thức thanh toán thành công";
            }
            catch (Exception)
            {
                return "Lỗi khi hình thức lịch sử thanh toán";
            }
        }

        public string UpdateHThucThanhToan(HinhThucThanhToan thanhToan, Guid id)
        {
            var existinghinhthuc = _context.HinhThucThanhToans.Find(id);
            if (existinghinhthuc == null)
            {
                return "hình thức thanh toán không tồn tại";
            }

            
            existinghinhthuc.TenHinhThuc = thanhToan.TenHinhThuc;
            existinghinhthuc.TrangThai = thanhToan.TrangThai;

            try
            {
                _context.HinhThucThanhToans.Update(existinghinhthuc);
                _context.SaveChanges();
                return "Cập nhật hình thức thanh toán thành công";
            }
            catch (Exception)
            {
                return "Lỗi khi cập nhật hình thức thanh toán";
            }
        }

        public string DeleteHThucThanhToan(Guid id)
        {
            var thanhToan = _context.HinhThucThanhToans.Find(id);
            if (thanhToan == null)
            {
                return "hình thức thanh toán không tồn tại";
            }

            try
            {
                _context.HinhThucThanhToans.Remove(thanhToan);
                _context.SaveChanges();
                return "Xóa hình thức thanh toán thành công";
            }
            catch (Exception)
            {
                return "Lỗi khi xóa hình thức thanh toán do khóa ngoại";
            }
        }
    }
}
