using DAL1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interfaces
{
    public interface Interface_KhachHang
    {
        public List<KhachHang> Tai_Du_Lieu();
        public List<KhachHang> Tim_Kiem(string DauVao);
        public KhachHang Them_Khach_Hang(KhachHang Moi);
        public void Cap_Nhat(KhachHang MucTieu);
        public void Xoa(KhachHang MucTieu);
    }
}
