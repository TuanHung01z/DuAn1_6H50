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
    public class YCDichVuServices : IYCDichVuServices
    {
        YCDichVuRepo repo = new YCDichVuRepo();
        public YCDichVuServices()
        {
                
        }
        public List<DichVu> GetAllDV()
        {
            return repo.GetAll();
        }
    }
}
