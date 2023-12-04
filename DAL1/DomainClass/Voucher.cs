using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("Voucher")]
public partial class Voucher
{
    [Key]
    [StringLength(10)]
    public string MaVoucher { get; set; } = null!;

    [StringLength(100)]
    public string LoaiVoucher { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? GiaTri { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HanSuDung { get; set; }

    [InverseProperty("MaVoucherNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
