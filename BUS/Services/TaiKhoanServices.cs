using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class TaiKhoanServices
    {
        Pro131BhdtContext _context;
        public TaiKhoanServices()
        {
            _context = new Pro131BhdtContext();
        }
        public string Login(string username, string password)
        {
            var account = _context.TaiKhoans
                .FirstOrDefault(p => p.TenDangNhap == username && p.MatKhau == password);
            if (account == null)
            {
                return "";
            }
            else
            {
                return account.VaiTro + ":" + account.TenDangNhap;
            }
        }

        public string CreateAccount(string username, string password, int role)
        {
            var account = new TaiKhoan
            {
                TenDangNhap = username,
                MatKhau = password,
                VaiTro = role
            };
            try
            {
                _context.TaiKhoans.Add(account);
                _context.SaveChanges();
                return "Tạo thành công";
            }
            catch (Exception e)
            {
                return "Tạo thất bại " + e.Message;
            }
        }

        public List<TaiKhoan> GetAccounts()
        {
            return _context.TaiKhoans.ToList();
        }

        public string LockAccount(string username)
        {
            var account = _context.TaiKhoans.Find(username);
            if (account == null)
            {
                return "Không tìm thấy tài khoản";
            }
            if (account.VaiTro == 1)
            {
                return "Không thể khóa một tài khoản admin";
            }
            else if (account.VaiTro == 0)
            {
                return "Tài khoản đã bị khóa, không thể khóa thêm";
            }
            account.VaiTro = 0; // 0 là trạng thái khóa
            try
            {
                _context.TaiKhoans.Update(account);
                _context.SaveChanges();
                return "Đã khóa tài khoản " + username;
            }
            catch (Exception e)
            {
                return "Khóa thất bại " + e.Message;
            }
        }

        public string UnLockAccount(string username)
        {
            var account = _context.TaiKhoans.Find(username);
            if (account == null)
            {
                return "Không tìm thấy tài khoản";
            }
            if (account.VaiTro != 0)
            {
                return "Không thể mở khóa cho tài khoản không bị khóa";
            }
            account.VaiTro = 2; // 2 là user thường
            try
            {
                _context.TaiKhoans.Update(account);
                _context.SaveChanges();
                return "Đã mở khóa tài khoản " + username;
            }
            catch (Exception e)
            {
                return "Mở khóa thất bại " + e.Message;
            }
        }

        public string UpdateAccount(string username, string password, int role)
        {
            var account = _context.TaiKhoans.Find(username);
            if (account == null)
            {
                return "Không tìm thấy tài khoản cần sửa";
            }
            account.MatKhau = password;
            account.VaiTro = role;
            try
            {
                _context.TaiKhoans.Update(account);
                _context.SaveChanges();
                return "Sửa thành công";
            }
            catch (Exception e)
            {
                return "Sửa thất bại " + e.Message;
            }
        }
        public string DeleteAccount(string username) 
        {
            var account = _context.TaiKhoans.Find(username);
            if(account == null)
            {
                return "Không tìm thấy tài khoản cần xóa"; 
            }
            try
            {
                _context.TaiKhoans.Remove(account);
                _context.SaveChanges();
                return "Xóa thành công";

            }
            catch (Exception e) 
            {
                return "Xóa thất bại";
            }
        }
    }
}
