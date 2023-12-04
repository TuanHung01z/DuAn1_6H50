using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("DaoDien")]
public partial class DaoDien
{
    [Key]
    [StringLength(10)]
    public string MaDaoDien { get; set; } = null!;

    [StringLength(30)]
    public string TenDaoDien { get; set; } = null!;

    public string? MoTaDaoDien { get; set; }

    [InverseProperty("MaDaoDienNavigation")]
    public virtual ICollection<Phim> Phims { get; set; } = new List<Phim>();
}
