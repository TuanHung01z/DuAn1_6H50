using DAL1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.IRepos
{
    public interface IYCDichVuRepo
    {
        public List<DichVu> GetAll();   
    }
}
