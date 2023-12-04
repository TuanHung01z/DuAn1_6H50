﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("LichChieu")]
public partial class LichChieu
{
    [Key]
    [StringLength(10)]
    public string MaLichChieu { get; set; } = null!;

    [StringLength(10)]
    public string MaPhim { get; set; } = null!;

    [StringLength(10)]
    public string MaPhongChieu { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ThoiGianChieu { get; set; }

    [ForeignKey("MaPhim")]
    [InverseProperty("LichChieus")]
    public virtual Phim MaPhimNavigation { get; set; } = null!;

    [ForeignKey("MaPhongChieu")]
    [InverseProperty("LichChieus")]
    public virtual PhongChieu MaPhongChieuNavigation { get; set; } = null!;

    [InverseProperty("MaLichChieuNavigation")]
    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}