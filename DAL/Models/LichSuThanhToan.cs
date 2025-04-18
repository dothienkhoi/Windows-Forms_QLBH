using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LichSuThanhToan
{
    public Guid MaLichSu { get; set; }

    public Guid MaHoaDon { get; set; }

    public Guid MaHinhThuc { get; set; }

    public long SoTien { get; set; }

    public string? GhiChu { get; set; }

    public virtual HinhThucThanhToan MaHinhThucNavigation { get; set; } = null!;

    public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;
}
