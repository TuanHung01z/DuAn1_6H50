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
    [StringLength(10)]
    public string MaKhachHang { get; set; } = null!;

    [Column("SDTKhachHang")]
    [StringLength(20)]
    public string SdtkhachHang { get; set; } = null!;

    [StringLength(255)]
    public string? DiaChi { get; set; }

    public int? TichDiem { get; set; }

    [StringLength(50)]
    public string? HangKhachHang { get; set; }

    [InverseProperty("MaKhachHangNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
