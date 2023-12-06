using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.DomainClass
{
    public class TheThanhVien
    {
        [Key]
        [ForeignKey("SDTKhachHang")]
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
        [InverseProperty("SDTKhachHangNavigation")]
        public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
    }
}
