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
    public class VoucherSver
    {
        Voucherepo voucherepo;
        Pro131BhdtContext _context;
        public VoucherSver()
        {
            voucherepo = new Voucherepo();
            _context = new Pro131BhdtContext();
        }
        public List<Voucher> GetAllVouchers()
        {
            return voucherepo.GetAllVouchers();
        }

        public Voucher GetVoucherById(string id)
        {
            return voucherepo.GetVoucherById(id);
        }

        public string CreateVoucher(Voucher voucher)
        {
            return voucherepo.CreateVoucher(voucher);
        }

        public string UpdateVoucher(Voucher voucher)
        {
            return voucherepo.UpdateVoucher(voucher);
        }

        public string DeleteVoucher(string id)
        {
            return voucherepo.DeleteVoucher(id);
        }
        public List<Voucher> GetVouchersByCustomerPhoneNumber(string phoneNumber)
        {
            return _context.DoiDiemLayVouchers
                           .Where(d => d.SoDienThoaiKhachHang == phoneNumber)
                           .Select(d => d.MaVoucherNavigation)
                           .ToList();
        }
    }
}
