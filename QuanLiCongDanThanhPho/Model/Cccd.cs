using System;
using System.Collections.Generic;

namespace QuanLiCongDanThanhPho.Model;

public partial class Cccd
{
    public string MaCccd { get; set; } = null!;

    public string? DacDiem { get; set; }

    public DateTime? NgayCap { get; set; }

    public virtual ICollection<Honnhan> HonnhanCccdnamNavigations { get; } = new List<Honnhan>();

    public virtual ICollection<Honnhan> HonnhanCccdnuNavigations { get; } = new List<Honnhan>();

    public virtual Khaisinh? Khaisinh { get; set; }

    public virtual Congdan MaCccdNavigation { get; set; } = null!;

    public virtual Tamtrutamvang? Tamtrutamvang { get; set; }

    public virtual ICollection<Thue> Thues { get; } = new List<Thue>();
}
