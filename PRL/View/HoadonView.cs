using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRL.View
{
    public class HoadonView
    {
        public Guid Id { get; set; }

        public long TongTien { get; set; }

        public string MaTaiKhoan { get; set; } = null!;

        public string? SoDienThoaiKhachHang { get; set; }

        public DateTime NgayTao { get; set; }

        public int TrangThai { get; set; }

        public string? MaVoucher { get; set; }

        public long TongTienMoi {  get; set; }
    }
}
