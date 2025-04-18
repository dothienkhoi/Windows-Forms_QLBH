using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhachHang
{
    public string SoDienThoai { get; set; } = null!;

    public string TenKhachHang { get; set; } = null!;

    public int DiemTichLuy { get; set; }

    public virtual ICollection<DoiDiemLayVoucher> DoiDiemLayVouchers { get; set; } = new List<DoiDiemLayVoucher>();

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
