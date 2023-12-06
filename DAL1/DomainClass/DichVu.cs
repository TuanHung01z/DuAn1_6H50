using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("DichVu")]
public partial class DichVu
{
    [Key]
    [StringLength(10)]
    public string MaDichVu { get; set; } = null!;

    [StringLength(70)]
    public string TenDichVu { get; set; } = null!;

    [Column(TypeName = "int")]
    public int GiaDichVu { get; set; }

    [StringLength(70)]
    public string TrangThaiDichVu { get; set; } = null!;

    [InverseProperty("MaDichVuNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();
}
