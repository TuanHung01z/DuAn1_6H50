using DAL1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IYCDichVuServices
    {
        public List<DichVu> GetAllDV();
    }
}
