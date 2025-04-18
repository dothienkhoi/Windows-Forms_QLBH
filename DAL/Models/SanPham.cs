using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPham
{
    public Guid MaSanPham { get; set; }

    public string TenSanPham { get; set; } = null!;

    public string? MoTaSanPham { get; set; }

    public string? HinhAnh { get; set; }

    public string? XuatXu { get; set; }

    public long Gia { get; set; }

    public int SoLuongCon { get; set; }

    public int TrangThai { get; set; }

    public Guid? MaKhuyenMai { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhuyenMai? MaKhuyenMaiNavigation { get; set; }
}
