using System;
using System.Collections.Generic;

namespace QuanLiCongDanThanhPho.Model;

public partial class Congdan
{
    public string Cccd { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string? NgheNghiep { get; set; }

    public string? Sdt { get; set; }

    public string? TonGiao { get; set; }

    public string? MaHk { get; set; }

    public string? QuanHeVoiChuHo { get; set; }

    public virtual Cccd? CccdNavigation { get; set; }

    public virtual Hokhau? MaHkNavigation { get; set; }
}
