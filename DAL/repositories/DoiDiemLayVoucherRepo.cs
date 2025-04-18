using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repositories
{
    public class DoiDiemLayVoucherRepo
    {
        Pro131BhdtContext _context;
        public DoiDiemLayVoucherRepo()
        {
             _context = new Pro131BhdtContext();
        }
        public List<DoiDiemLayVoucher> GetAllđoiiem()
        {
            return _context.DoiDiemLayVouchers.ToList();
        }
        public DoiDiemLayVoucher GetById(Guid id) 
        {
            return _context.DoiDiemLayVouchers.Find(id);
        }
        public string DeleteĐoiiem(Guid id)
        {
            var doiDiem = _context.DoiDiemLayVouchers.Find(id);

            if (doiDiem == null)
            {
                return "Đối tượng không tồn tại.";
            }

            // Xóa đối tượng
            _context.DoiDiemLayVouchers.Remove(doiDiem);

            try
            {
                _context.SaveChanges();
                return "Xóa đối tượng thành công.";
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                return $"Xóa đối tượng không thành công: {ex.Message}";
            }
        }
        public string DoiDiemLayVoucher(string soDienThoaiKhachHang, int soDiemCanDoi, string mavoucher)
        {
            // Lấy thông tin khách hàng
            var khachHang = _context.KhachHangs
                .FirstOrDefault(kh => kh.SoDienThoai == soDienThoaiKhachHang);

            if (khachHang == null)
            {
                return "Khách hàng không tồn tại.";
            }

            // Kiểm tra số điểm của khách hàng
            if (khachHang.DiemTichLuy < soDiemCanDoi)
            {
                return "Không đủ điểm để đổi voucher.";
            }

            // Tính giá trị giảm dựa trên số điểm
            int giaTriGiam = 0;
            if (soDiemCanDoi <= 10000)
            {
                giaTriGiam = soDiemCanDoi / 1000 * 10;
            }
            else
            {
                giaTriGiam = 100; // Giới hạn giá trị giảm tối đa là 100%
            }

            // Tạo một voucher mới
            
            var voucher = new Voucher
            {
                MaVoucher = mavoucher,
                TenVoucher = $"Voucher giảm {giaTriGiam}%",
                MoTa = $"Giảm {giaTriGiam}% cho lần mua hàng tiếp theo",
                GiaTriGiam = giaTriGiam,
                NgayBatDau = DateTime.Now,
                NgayKetThuc = DateTime.Now.AddMonths(1), // Voucher có hạn một tháng
                TrangThai = 1 // Voucher mới được tạo ra sẽ khả dụng
            };

            _context.Vouchers.Add(voucher);

            // Tạo bản ghi đổi điểm lấy voucher
            var doiDiem = new DoiDiemLayVoucher
            {
                MaDoiDiem = Guid.NewGuid(),
                SoDienThoaiKhachHang = soDienThoaiKhachHang,
                MaVoucher = mavoucher,
                NgayDoi = DateTime.Now,
                SoDiem = soDiemCanDoi,
            };

            _context.DoiDiemLayVouchers.Add(doiDiem);

            
            khachHang.DiemTichLuy -= soDiemCanDoi;

            
            _context.SaveChanges();

            return $"Đổi điểm lấy voucher thành công. Bạn đã nhận được voucher giảm {giaTriGiam}%.";
        }
        public string CapNhatDiemTichLuy(string soDienThoaiKhachHang, int soDiemdoi)
        {
            // Lấy thông tin khách hàng
            var khachHang = _context.KhachHangs
                .FirstOrDefault(kh => kh.SoDienThoai == soDienThoaiKhachHang);

            if (khachHang == null)
            {
                return "Khách hàng không tồn tại.";
            }
            int sodiemmoi = khachHang.DiemTichLuy;
            // Cập nhật điểm tích lũy
            sodiemmoi = khachHang.DiemTichLuy -soDiemdoi;

            _context.SaveChanges();

            return $"Cập nhật điểm tích lũy thành công. Điểm tích lũy mới của khách hàng là {sodiemmoi}.";
        }
    }
}
