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
    public class VoucherRepo : IVoucherRepo
    {
        DBContext _dbcontext;
        public VoucherRepo()
        {
            _dbcontext = new DBContext();
        }

        public bool AddVc(Voucher vc)
        {
           _dbcontext.Add(vc);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<Voucher> GetAllVC()
        {
            return _dbcontext.Vouchers.ToList();

        }

      
    }
}
