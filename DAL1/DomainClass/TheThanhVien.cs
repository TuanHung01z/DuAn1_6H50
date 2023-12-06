using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL1.DomainClass
{
    [Table("TheThanhVien")]
    public partial class TheThanhVien
    {
        [Key]
        [StringLength(25)]
        public string SDTKhachHang { get; set; } = null!;
        [Column(TypeName = "int")]
        public int DiemThanhVien { get; set; }
        [StringLength(50)]
        public string LoaiThanhVien { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? NgayHieuLuc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayHetHan { get; set; }

        [ForeignKey("SDTKhachHang")]
        [InverseProperty("TheThanhViens")]
        public virtual KhachHang SDTKhachHangNavigation_TTV { get; set; } = null!;
    }
}
