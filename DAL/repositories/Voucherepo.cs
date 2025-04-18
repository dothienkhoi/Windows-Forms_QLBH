using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repositories
{
    public class Voucherepo
    {
        Pro131BhdtContext _context;
        public Voucherepo()
        {
            _context = new Pro131BhdtContext();
        }
        public List<Voucher> GetAllVouchers()
        {
            return _context.Vouchers.ToList();
        }

        public Voucher GetVoucherById(string id)
        {
            return _context.Vouchers.Find(id);
        }

        public string CreateVoucher(Voucher voucher)
        {
            if (voucher.NgayBatDau > DateTime.Now || voucher.NgayKetThuc < DateTime.Now || voucher.NgayBatDau > voucher.NgayKetThuc)
            {
                return "Kiểm tra lại thời hạn của voucher";
            }
            try
            {
                _context.Vouchers.Add(voucher);
                _context.SaveChanges();
                return "Tạo mới voucher thành công";
            }
            catch (Exception)
            {
                return "Lỗi khi tạo mới voucher";
            }
        }

        public string UpdateVoucher(Voucher voucher)
        {
            var existingVoucher = _context.Vouchers.Find(voucher.MaVoucher);
            if (existingVoucher == null)
            {
                return "Voucher không tồn tại";
            }

            if ( voucher.NgayKetThuc < DateTime.Now || voucher.NgayBatDau > voucher.NgayKetThuc)
            {
                return "Kiểm tra lại thời hạn của voucher";
            }
            else
            {
                existingVoucher.TenVoucher = voucher.TenVoucher;
                existingVoucher.MoTa = voucher.MoTa;
                existingVoucher.GiaTriGiam = voucher.GiaTriGiam;
                existingVoucher.NgayBatDau = voucher.NgayBatDau;
                existingVoucher.NgayKetThuc = voucher.NgayKetThuc;
                existingVoucher.TrangThai = voucher.TrangThai;

                _context.SaveChanges();
                return "Cập nhật voucher thành công";
            }
        }

        public string DeleteVoucher(string id)
        {
            var voucher = _context.Vouchers.Find(id);
            if (voucher == null)
            {
                return "Voucher không tồn tại";
            }

            try
            {
                _context.Vouchers.Remove(voucher);
                _context.SaveChanges();
                return "Xóa voucher thành công";
            }
            catch (Exception)
            {
                return "Lỗi khi xóa voucher";
            }
        }
    }
}
