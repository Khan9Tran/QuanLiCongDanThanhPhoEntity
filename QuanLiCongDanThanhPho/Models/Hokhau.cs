using System;
using System.Collections.Generic;

namespace QuanLiCongDanThanhPho.Model;

public partial class Hokhau
{
    public string MaHk { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? CccdchuHo { get; set; }

    public virtual ICollection<Congdan> Congdans { get; } = new List<Congdan>();
}
