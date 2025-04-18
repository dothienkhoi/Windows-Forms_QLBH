using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ChiTietHoaDon
{
    public Guid MaChiTiet { get; set; }

    public Guid MaHoaDon { get; set; }

    public Guid MaSanPham { get; set; }

    public long GiaSanPham { get; set; }

    public int SoLuong { get; set; }

    public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;

    public virtual SanPham MaSanPhamNavigation { get; set; } = null!;
}
