using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass;

[Table("ThongKe")]
public partial class ThongKe
{
    [Key]
    [StringLength(10)]
    public string MaThongKe { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? DoanhThuPhimNgay { get; set; }

    [Column(TypeName = "money")]
    public decimal? DoanhThuDichVuNgay { get; set; }

    public int? SoVeDaBan { get; set; }
}
