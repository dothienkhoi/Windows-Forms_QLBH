using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Voucher
{
    public string MaVoucher { get; set; } = null!;

    public string TenVoucher { get; set; } = null!;

    public string? MoTa { get; set; }

    public long GiaTriGiam { get; set; }

    public DateTime NgayBatDau { get; set; }

    public DateTime NgayKetThuc { get; set; }

    public int TrangThai { get; set; }

    public virtual ICollection<DoiDiemLayVoucher> DoiDiemLayVouchers { get; set; } = new List<DoiDiemLayVoucher>();

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
