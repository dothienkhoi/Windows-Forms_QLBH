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
    public class SaleSver
    {
        Pro131BhdtContext _context;
        SaleRepo saleRepo;
        public SaleSver()
        {
            _context = new Pro131BhdtContext();
            saleRepo = new SaleRepo();
        }
        public List<KhuyenMai> GetAll()
        {
            return saleRepo.GetAllKmai();
        }

        public KhuyenMai GetKmById(Guid id)
        {
            return saleRepo.GetKmaiById(id);
        }
        public List<KhuyenMai> GetActiveSale() // Lấy ra danh sách các sale đang hoạt động
        {
            return _context.KhuyenMais.Where(p => p.NgayBatDau <= DateTime.Now
            && p.NgayKetThuc >= DateTime.Now && p.TrangThai == 0).ToList(); // Hoạt động = 0, ko HĐ = 1
        }

        public string Create(KhuyenMai khuyenMai)
        {
            return saleRepo.CreateSale(khuyenMai);
        }

        public string Update(KhuyenMai khuyenMai, Guid id)
        {
            return saleRepo.UpdateSale(khuyenMai, id);
        }

        public string Delete(Guid id)
        {
            return saleRepo.DeleteSale(id);
        }
    }
}
