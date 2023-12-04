using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("PhongChieu")]
public partial class PhongChieu
{
    [Key]
    [StringLength(10)]
    public string MaPhongChieu { get; set; } = null!;

    public int SoGhe { get; set; }

    public int? SoGheDaDat { get; set; }

    [StringLength(30)]
    public string? TrangThai { get; set; }

    [InverseProperty("MaPhongChieuNavigation")]
    public virtual ICollection<Ghe> Ghes { get; set; } = new List<Ghe>();

    [InverseProperty("MaPhongChieuNavigation")]
    public virtual ICollection<LichChieu> LichChieus { get; set; } = new List<LichChieu>();

    [InverseProperty("MaPhongChieuNavigation")]
    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
