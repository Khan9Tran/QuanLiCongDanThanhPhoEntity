using System;
using System.Collections.Generic;

namespace QuanLiCongDanThanhPho.Model;

public partial class Account
{
    public string UserName { get; set; } = null!;

    public string? StrPassword { get; set; }

    public int? QuyenTruyCap { get; set; }

    public string? DisplayName { get; set; }
}
