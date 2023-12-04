using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("DienVien")]
public partial class DienVien
{
    [Key]
    [StringLength(10)]
    public string MaDienVien { get; set; } = null!;

    [StringLength(30)]
    public string TenDienVien { get; set; } = null!;

    public string? MoTaDienVien { get; set; }

    [InverseProperty("MaDienVienNavigation")]
    public virtual ICollection<Phim> Phims { get; set; } = new List<Phim>();
}
