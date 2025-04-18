using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDon
{
    public Guid MaHoaDon { get; set; }

    public long TongTien { get; set; }

    public string MaTaiKhoan { get; set; } = null!;

    public string? SoDienThoaiKhachHang { get; set; }

    public DateTime NgayTao { get; set; }

    public int TrangThai { get; set; }

    public string? MaVoucher { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual ICollection<LichSuThanhToan> LichSuThanhToans { get; set; } = new List<LichSuThanhToan>();

    public virtual TaiKhoan MaTaiKhoanNavigation { get; set; } = null!;

    public virtual Voucher? MaVoucherNavigation { get; set; }

    public virtual KhachHang? SoDienThoaiKhachHangNavigation { get; set; }
}
