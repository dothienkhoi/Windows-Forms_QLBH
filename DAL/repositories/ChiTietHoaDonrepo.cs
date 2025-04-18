using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repositories
{
    public class ChiTietHoaDonrepo
    {
        Pro131BhdtContext _context;
        public ChiTietHoaDonrepo()
        {
            _context = new Pro131BhdtContext();
        }
    }
}
