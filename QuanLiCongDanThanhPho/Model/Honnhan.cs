using System;
using System.Collections.Generic;

namespace QuanLiCongDanThanhPho.Model;

public partial class Honnhan
{
    public string MaHonNhan { get; set; } = null!;

    public string? Cccdnam { get; set; }

    public string? TenNam { get; set; }

    public string? Cccdnu { get; set; }

    public string? TenNu { get; set; }

    public string? NoiDangKy { get; set; }

    public DateTime? NgayDangKy { get; set; }

    public virtual Cccd? CccdnamNavigation { get; set; }

    public virtual Cccd? CccdnuNavigation { get; set; }
}
