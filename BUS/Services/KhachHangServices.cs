using BUS.IServices;
using DAL1.DomainClass;
using DAL1.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class KhachHangServices : IKhachHangServices
    {
        KhachHangRepo _repos;
        public KhachHangServices()
        {
            _repos = new KhachHangRepo();
        }
        public string Add(KhachHang kh)
        {
            if (_repos.AddKH(kh) == true)
            {
                return "Thêm khách hàng thành công";
            }
            else
            {
                return "Thêm khách hàng thất bại";
            }
        }

        public List<KhachHang> GetAll(string search)
        {
            if (search == null)
            {
                return _repos.GetAllKH();
            }
            else
            {
                return _repos.GetAllKH().Where(x => x.SdtkhachHang.Contains(search) || x.TenKhachHang.Contains(search)).ToList();
            }
        }

        public string Remove(KhachHang kh)
        {
            var clone = _repos.GetAllKH().FirstOrDefault(x => x.SdtkhachHang == kh.SdtkhachHang);
            if (_repos.RemoveKH(clone) == true)
            {
                return "Xoá khách hàng thành công";
            }
            else
            {
                return "Xoá khách hàng thất bại";
            }
        }

        public string Update(KhachHang kh)
        {
            var clone = _repos.GetAllKH().FirstOrDefault(x => x.SdtkhachHang == kh.SdtkhachHang);
            clone.TenKhachHang = kh.TenKhachHang;
            clone.DiaChi = kh.DiaChi;
            clone.TichDiem = kh.TichDiem;
            clone.HangKhachHang = kh.HangKhachHang;
            if (_repos.UpdateKH(clone) == true)
            {
                return "Sửa khách hàng thành công";
            }
            else
            {
                return "Sửa khách hàng thất bại";
            }
        }
    }
}
