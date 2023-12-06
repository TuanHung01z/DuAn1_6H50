using DAL1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.IRepos
{
    internal interface IVoucherRepo
    {
        public bool AddVc(Voucher vc);
        public List<Voucher> GetAllVC();
    }
}
