using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("HoaDon")]
public partial class HoaDon
{
    [Key]
    [StringLength(10)]
    public string MaHoaDon { get; set; } = null!;

    [StringLength(30)]
    public string HinhThucThanhToan { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal SoTien { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ThoiGianThanhToan { get; set; }

    [StringLength(20)]
    public string TrangThaiThanhToan { get; set; } = null!;

    [StringLength(10)]
    public string MaKhachHang { get; set; } = null!;

    [StringLength(10)]
    public string? MaVoucher { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ThoiGianXacNhanHoaDon { get; set; }

    [InverseProperty("MaHoaDonNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    [ForeignKey("MaKhachHang")]
    [InverseProperty("HoaDons")]
    public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;

    [ForeignKey("MaVoucher")]
    [InverseProperty("HoaDons")]
    public virtual Voucher? MaVoucherNavigation { get; set; }
}
