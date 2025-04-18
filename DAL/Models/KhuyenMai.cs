using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhuyenMai
{
    public Guid MaKhuyenMai { get; set; }

    public string TenKhuyenMai { get; set; } = null!;

    public string? MoTaKhuyenMai { get; set; }

    public double PhanTramGiam { get; set; }

    public DateTime NgayBatDau { get; set; }

    public DateTime NgayKetThuc { get; set; }

    public int TrangThai { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
