using System;
using System.Collections.Generic;

namespace QuanLiCongDanThanhPho.Model;

public partial class Khaisinh
{
    public string MaKs { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public DateTime NgaySinh { get; set; }

    public DateTime? NgayDangKy { get; set; }

    public string GioiTinh { get; set; } = null!;

    public string DanToc { get; set; } = null!;

    public string QuocTich { get; set; } = null!;

    public string? NoiSinh { get; set; }

    public string? QueQuan { get; set; }

    public string? Cccdcha { get; set; }

    public string? TenCha { get; set; }

    public string? Cccdme { get; set; }

    public string? TenMe { get; set; }

    public virtual Cccd MaKsNavigation { get; set; } = null!;
}
