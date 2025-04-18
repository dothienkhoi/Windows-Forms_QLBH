using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonSver
    {
        Pro131BhdtContext _context;
        public HoaDonSver()
        {
            _context = new Pro131BhdtContext();
        }
        public List<HoaDon> GetAllHoaDon()
        {
            return _context.HoaDons.ToList();
        }

        public List<HoaDon> GetWaitHoaDon()
        {
            return _context.HoaDons.Where(p => p.TrangThai == 0).ToList();
        }
        public string CreateHD(HoaDon hoaDon)
        {
            
                _context.HoaDons.Add(hoaDon);
                _context.SaveChanges();

                return "Tạo thành công";
             
        }
        public string DeleteHD(Guid hoaDonId)
        {
            try
            {
                var hoaDon = _context.HoaDons.Find(hoaDonId);
                if (hoaDon == null)
                {
                    return "Hóa đơn không tồn tại";
                }

                _context.HoaDons.Remove(hoaDon);
                _context.SaveChanges();
                return "Xóa thành công";
            }
            catch (Exception) 
            {
                return "Xóa Thất bại do khóa ngoại";
            }
           
        }
        public string UpdateHoaDonStatus(Guid hoaDonId, int trangThai)
        {
            var hoaDon = _context.HoaDons.Find(hoaDonId);
            if (hoaDon == null)
            {
                return "Hóa đơn không tồn tại.";
            }
            try
            {
             

                hoaDon.TrangThai = trangThai;
                _context.HoaDons.Update(hoaDon);
                _context.SaveChanges();

                return "Cập nhật trạng thái hóa đơn thành công.";
            }
            catch(Exception ex)
            {
                return "Thất Bại"+ex.Message;
            }
            
        }
        public string CreateLsthanhtoan(Guid maHoaDon, Guid maHinhThuc, long soTienKhachDua, long tongTienHoaDon)
        {
            var hoaDon = _context.HoaDons.Find(maHoaDon);
            if (hoaDon == null)
            {
                return "Hóa đơn không tồn tại.";
            }

            long soTienCanTra = soTienKhachDua - tongTienHoaDon;
            string ghiChu = $"Số tiền khách đưa: {soTienKhachDua}, Số tiền cần trả: {soTienCanTra}";

            var lichSuThanhToan = new LichSuThanhToan
            {
                MaLichSu = Guid.NewGuid(),
                MaHoaDon = maHoaDon,
                MaHinhThuc = maHinhThuc,
                SoTien = soTienKhachDua,
                GhiChu = ghiChu

            };
                

                _context.LichSuThanhToans.Add(lichSuThanhToan);
                _context.SaveChanges();

            return "Thanh Toan va Tạo lịch sử thanh toán thành công.";
            
        }
    }
}
