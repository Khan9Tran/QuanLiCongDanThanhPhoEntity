using System;
using System.Collections.Generic;

namespace QuanLiCongDanThanhPho.Model;

public partial class Thue
{
    public string MaThue { get; set; } = null!;

    public string? Cccd { get; set; }

    public string? SoTienCanNop { get; set; }

    public string? SoTienDaNop { get; set; }

    public DateTime? NgayCap { get; set; }

    public DateTime? HanNop { get; set; }

    public virtual Cccd? CccdNavigation { get; set; }
}
