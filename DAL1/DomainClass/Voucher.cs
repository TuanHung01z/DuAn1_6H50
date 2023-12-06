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

    [StringLength(30)]
    public string LoaiVoucher { get; set; } = null!;

    public int GiaTri { get; set; }

    [Column(TypeName = "date")]
    public DateTime? HanSuDung { get; set; }

    [InverseProperty("MaVoucherNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
