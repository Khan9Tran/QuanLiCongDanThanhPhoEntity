using System;
using System.Collections.Generic;

namespace QuanLiCongDanThanhPho.Model;

public partial class Tamtrutamvang
{
    public string? MaTttv { get; set; }

    public string Cccd { get; set; } = null!;

    public string? DiaChi { get; set; }

    public DateTime? NgayBd { get; set; }

    public DateTime? NgayKt { get; set; }

    public string? TrangThai { get; set; }

    public string? LiDo { get; set; }

    public virtual Cccd CccdNavigation { get; set; } = null!;
}
