using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repositories
{
    public class SaleRepo
    {
        Pro131BhdtContext _context;
        public SaleRepo()
        {
            _context = new Pro131BhdtContext();
        }
        public List<KhuyenMai> GetAllKmai()
        {
            return _context.KhuyenMais.ToList();
        }

        public KhuyenMai GetKmaiById(Guid id)
        {
            return _context.KhuyenMais.Find(id);
        }

        public string CreateSale(KhuyenMai khuyenMai)
        {
            if ( khuyenMai.NgayKetThuc < DateTime.Now || khuyenMai.NgayBatDau > khuyenMai.NgayKetThuc)
            {
                return "Kiểm tra lại thời hạn của chương trình khuyến mãi";
            }
            else if (khuyenMai.PhanTramGiam > 100 || khuyenMai.PhanTramGiam < 0)
            {
                return "% giảm không thể ngoài khoảng 0-100";
            }
            try
            {
                _context.KhuyenMais.Add(khuyenMai);
                _context.SaveChanges();
                return "Tạo mới khuyến mãi thành công";
            }
            catch (Exception)
            {
                return "Lỗi khi tạo mới khuyến mãi";
            }
        }

        public string UpdateSale(KhuyenMai khuyenMai, Guid id)
        {
            var existingSale = _context.KhuyenMais.Find(id);
            if (existingSale == null)
            {
                return "Khuyến mãi không tồn tại";
            }

            if ( khuyenMai.NgayKetThuc < DateTime.Now || khuyenMai.NgayBatDau > khuyenMai.NgayKetThuc)
            {
                return "Kiểm tra lại thời hạn của chương trình khuyến mãi";
            }
            else if (khuyenMai.PhanTramGiam > 100 || khuyenMai.PhanTramGiam < 0)
            {
                return "% giảm không thể ngoài khoảng 0-100";
            }
            else
            {
                existingSale.TenKhuyenMai = khuyenMai.TenKhuyenMai;
                existingSale.MoTaKhuyenMai = khuyenMai.MoTaKhuyenMai;
                existingSale.PhanTramGiam = khuyenMai.PhanTramGiam;
                existingSale.NgayBatDau = khuyenMai.NgayBatDau;
                existingSale.NgayKetThuc = khuyenMai.NgayKetThuc;
                existingSale.TrangThai = khuyenMai.TrangThai;

                _context.SaveChanges();
                return "Cập nhật khuyến mãi thành công";
            }
        }

        public string DeleteSale(Guid id)
        {
            var sale = _context.KhuyenMais.Find(id);
            if (sale == null)
            {
                return "Khuyến mãi không tồn tại";
            }

            try
            {
                _context.KhuyenMais.Remove(sale);
                _context.SaveChanges();
                return "Xóa khuyến mãi thành công";
            }
            catch (Exception)
            {
                return "Lỗi khi xóa khuyến mãi";
            }
        }

    }
}
