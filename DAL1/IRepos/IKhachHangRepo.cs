using DAL1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.IRepos
{
    public interface IKhachHangRepo
    {
        public bool AddKH(KhachHang kh);
        public bool UpdateKH(KhachHang kh);
        public bool RemoveKH(KhachHang kh);
        public List<KhachHang> GetAllKH();

    }
}
