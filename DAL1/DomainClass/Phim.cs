﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("Phim")]
public partial class Phim
{
    [Key]
    [StringLength(10)]
    public string MaPhim { get; set; } = null!;

    [StringLength(70)]
    public string TenPhim { get; set; } = null!;

    [StringLength(30)]
    public string NgonNgu { get; set; } = null!;

    [StringLength(10)]
    public string MaTheLoai { get; set; } = null!;

    [StringLength(10)]
    public string MaDaoDien { get; set; } = null!;

    [StringLength(10)]
    public string MaDienVien { get; set; } = null!;

    public string? MoTa { get; set; }

    [StringLength(10)]
    public string? Rated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime NgayPhatHanh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ThoiLuong { get; set; }

    [InverseProperty("MaPhimNavigation")]
    public virtual ICollection<LichChieu> LichChieus { get; set; } = new List<LichChieu>();

    [ForeignKey("MaDaoDien")]
    [InverseProperty("Phims")]
    public virtual DaoDien MaDaoDienNavigation { get; set; } = null!;

    [ForeignKey("MaDienVien")]
    [InverseProperty("Phims")]
    public virtual DienVien MaDienVienNavigation { get; set; } = null!;

    [ForeignKey("MaTheLoai")]
    [InverseProperty("Phims")]
    public virtual TheLoai MaTheLoaiNavigation { get; set; } = null!;

    [InverseProperty("MaPhimNavigation")]
    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
