using DAL1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    internal interface IKhachHangServices
    {
        public string Add(KhachHang kh);
        public string Update(KhachHang kh);
        public string Remove(KhachHang kh);
        List<KhachHang> GetAll(string search);
    }
}
