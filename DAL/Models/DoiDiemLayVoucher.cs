using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class DoiDiemLayVoucher
{
    public Guid MaDoiDiem { get; set; }

    public string SoDienThoaiKhachHang { get; set; } = null!;

    public string MaVoucher { get; set; } = null!;

    public DateTime NgayDoi { get; set; }

    public int SoDiem { get; set; }

    public virtual Voucher MaVoucherNavigation { get; set; } = null!;

    public virtual KhachHang SoDienThoaiKhachHangNavigation { get; set; } = null!;
}
