using DAL.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ChiTietHoaDonSver
    {
        Pro131BhdtContext _context;
        public ChiTietHoaDonSver()
        {
            _context = new Pro131BhdtContext();
        }
        public List<ChiTietHoaDon> GetALLHDCT()
        {
            return _context.ChiTietHoaDons.ToList();
        }

        public List<ChiTietHoaDon> GetByid(Guid idhdct)
        {
            return _context.ChiTietHoaDons.Where(p => p.MaHoaDon == idhdct).ToList();
        }

        public string AddToBill(Guid hoadonID, Guid sanphamID, long gia  , int soluong)
        {
            try
            {
                var check = _context.ChiTietHoaDons.FirstOrDefault(p => p.MaHoaDon == hoadonID && p.MaSanPham == sanphamID);

                if (check == null) // SP mới chưa có trong hóa đơn
                {
                    var hoadon = new ChiTietHoaDon
                    {
                        MaChiTiet = Guid.NewGuid(),
                        MaHoaDon = hoadonID,
                        MaSanPham = sanphamID,
                        GiaSanPham = gia,
                        SoLuong = soluong
                    };
                    _context.ChiTietHoaDons.Add(hoadon);
                    _context.SaveChanges();

                    // Update số lượng của sản phẩm trong kho
                    var sapham = _context.SanPhams.Find(sanphamID);
                    sapham.SoLuongCon = sapham.SoLuongCon - soluong;
                    _context.SanPhams.Update(sapham);
                    _context.SaveChanges();

                    return "Thêm thành công vào hóa đơn";
                }
                else // SP đã có trong hóa đơn rồi => Update số lượng
                {
                    check.SoLuong += soluong; // update số lượng trong bill Details
                    _context.ChiTietHoaDons.Update(check);
                    _context.SaveChanges();

                    // Update số lượng của sản phẩm trong kho
                    var sapham = _context.SanPhams.Find(sanphamID);
                    sapham.SoLuongCon -= soluong;
                    _context.SanPhams.Update(sapham);
                    _context.SaveChanges();

                    return "Thêm mới và cộng dồn thành công";
                }
            }
            catch (Exception ex) 
            {
                return "Tạo thất bại" + ex.Message;
            }
            // Check xem SP đã nằm trong hóa đơn hay chưa
            
        }

        public void UpdateTotalAmount(Guid billID)
        {
            var details = _context.ChiTietHoaDons.Where(cthd => cthd.MaHoaDon == billID).ToList();
            long totalAmount = details.Sum(cthd => cthd.GiaSanPham * cthd.SoLuong);

            var bill = _context.HoaDons.Find(billID);
            if (bill != null)
            {
                bill.TongTien = totalAmount;
                _context.HoaDons.Update(bill);
                _context.SaveChanges();
            }
        }
        public string RefundProduct(Guid machitiet, Guid masanpham)
        {
            try
            {
                var billDetail = _context.ChiTietHoaDons.Find(machitiet);
                if (billDetail == null)
                {
                    return "Chi tiết hóa đơn không tồn tại.";
                }


                var product = _context.SanPhams.Find(masanpham);
                if (product == null)
                {
                    return "Sản phẩm không tồn tại.";
                }

                product.SoLuongCon += billDetail.SoLuong;

                _context.ChiTietHoaDons.Remove(billDetail);

                _context.SaveChanges();

                return "Hoàn trả sản phẩm thành công.";
            }
            catch (Exception ex)
            {
                return "Thất Bại" + ex.Message;
            }
            
        }
        public string HoanlaItongtien(Guid machitiet, Guid mahoadon, Guid masanpham)
        {

            var gia = _context.SanPhams.Find(masanpham);
            if (gia == null)
            {
                return "Sản Phẩm  không tồn tại.";
            }
            var soluong = _context.ChiTietHoaDons.Find(machitiet);
            if (soluong == null)
            {
                return "Chi tiết hóa đơn không tồn tại.";
            }
            var tongtien = _context.HoaDons.Find(mahoadon);
            if (tongtien == null)
            {
                return "Hóa đon ko tồn tại";
            }
            tongtien.TongTien = 0;
            _context.HoaDons.Update(tongtien);
            _context.SaveChanges();
            return "Tỏng tiền đã đc cập nhật";
        }


        public string DeleteBillDetail(Guid hoadonchitiet)
        {
            var detail = _context.ChiTietHoaDons.Find(hoadonchitiet);
            if (detail != null)
            {
                var product = _context.SanPhams.Find(detail.MaSanPham);
                product.SoLuongCon += detail.SoLuong; // Hoàn trả số lượng vào kho

                _context.ChiTietHoaDons.Remove(detail);
                _context.SaveChanges();

                _context.SanPhams.Update(product);
                _context.SaveChanges();

                return "Xóa thành công";
            }
            return "Chi tiết hóa đơn không tồn tại";
        }
        public string ThanhToanHoaDon(Guid hoaDonId, long soTienKhachTra, long tongTienMoi)
        {
            var hoaDon = _context.HoaDons.Find(hoaDonId);
            if (hoaDon == null)
            {
                return "Hóa đơn không tồn tại.";
            }

            var chiTietHoaDons = _context.ChiTietHoaDons.Where(ct => ct.MaHoaDon == hoaDonId).ToList();
            if (!chiTietHoaDons.Any())
            {
                return "Không có chi tiết hóa đơn để thanh toán.";
            }

            // Cập nhật tổng tiền mới từ lb_tongtienmoi
            hoaDon.TongTien = tongTienMoi;

            if (soTienKhachTra < hoaDon.TongTien)
            {
                return "Số tiền khách trả không đủ để thanh toán hóa đơn.";
            }

            hoaDon.TrangThai = 1; // Đánh dấu hóa đơn đã thanh toán
            _context.HoaDons.Update(hoaDon);

            //_context.ChiTietHoaDons.RemoveRange(chiTietHoaDons); // Xóa tất cả chi tiết hóa đơn liên quan
            _context.SaveChanges();

            return "Thanh toán thành công.";

        }
    } 
}
