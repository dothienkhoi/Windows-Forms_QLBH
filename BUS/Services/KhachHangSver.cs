using DAL.Models;
using DAL.repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class KhachHangSver
    {
        Pro131BhdtContext _context;
        KhachHangrepo khachHangrepo;
        public KhachHangSver()
        {
            _context = new Pro131BhdtContext();
            khachHangrepo = new KhachHangrepo();
        }
        public List<KhachHang> GetAll()
        {
            return khachHangrepo.GetAll();
        }
        public KhachHang GetByid(string id)
        {
            return khachHangrepo.GetById(id);
        }
        public List<KhachHang> GetByPhone(string phoneNumber)
        {
            var check = _context.KhachHangs.Where(p => p.SoDienThoai.Contains(phoneNumber)).ToList();
            return _context.KhachHangs.Where(p => p.SoDienThoai.Contains(phoneNumber)).ToList();
        } // Danh sách chứa để add Vào combobox khi muốn tìm kiếm
        // Tạo mới
        public void Createkhsp(string phoneNumber, string name, int point = 0)
        {
            KhachHang customer = new KhachHang()
            {
                SoDienThoai = phoneNumber,
                TenKhachHang = name,
                DiemTichLuy = point
            };
            _context.KhachHangs.Add(customer);
            _context.SaveChanges();
        }

        public string Create(KhachHang khach)
        {
            if (khachHangrepo.CreateKH(khach))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string Update(KhachHang khach, string sdt)
        {
            if (khachHangrepo.UpdateKh(khach, sdt))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        public string Delete(string sdt)
        {
            if (khachHangrepo.DeleteKH(sdt))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }
    }
}
