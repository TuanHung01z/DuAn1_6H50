using DAL1.Context;
using DAL1.DomainClass;
using DAL1.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.Repos
{
    public class YCDichVuRepo : IYCDichVuRepo
    {
        DBContext context = new DBContext();

        public YCDichVuRepo()
        {
                
        }
        public List<DichVu> GetAll()
        {
            return context.DichVus.ToList();
        }
    }
}
