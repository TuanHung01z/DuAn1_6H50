using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("Ghe")]
public partial class Ghe
{
    [Key]
    [StringLength(10)]
    public string MaGhe { get; set; } = null!;

    [StringLength(10)]
    public string MaPhongChieu { get; set; } = null!;

    [StringLength(20)]
    public string HangGhe { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal GiaGhe { get; set; }

    [StringLength(70)]
    public string TrangThai { get; set; } = null!;

    [ForeignKey("MaPhongChieu")]
    [InverseProperty("Ghes")]
    public virtual PhongChieu MaPhongChieuNavigation { get; set; } = null!;

    [InverseProperty("MaGheNavigation")]
    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
