using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HinhThucThanhToan
{
    public Guid MaHinhThuc { get; set; }

    public string TenHinhThuc { get; set; } = null!;

    public int TrangThai { get; set; }

    public virtual ICollection<LichSuThanhToan> LichSuThanhToans { get; set; } = new List<LichSuThanhToan>();
}
