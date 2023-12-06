using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("KhachHang")]
public partial class KhachHang
{
    [Key]
    [Column("SDTKhachHang")]
    [StringLength(20)]
    public string SdtkhachHang { get; set; } = null!;

    [StringLength(100)]
    public string TenKhachHang { get; set; } = null!;

    public string? DiaChi { get; set; }

    public int? TichDiem { get; set; }

    [StringLength(50)]
    public string? HangKhachHang { get; set; }

    [InverseProperty("SdtkhachHangNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
