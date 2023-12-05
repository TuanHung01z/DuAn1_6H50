using System;
using DAL1.DomainClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interfaces
{
    public interface Interface_TheThanhVien
    {
        List<TheThanhVien> TaiDuLieu();
        public TheThanhVien Them_Moi(TheThanhVien DuLieu);
        public void Cap_Nhat(TheThanhVien MucTieu);
        public void Xoa(TheThanhVien MucTieu);
    }
}
