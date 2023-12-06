﻿using DAL1.Context;
using DAL1.DomainClass;
using DAL1.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.Repos
{
    public class KhachHangRepo : IKhachHangRepo
    {
        DBContext _dbcontext;
        public KhachHangRepo()
        {
            _dbcontext  = new DBContext();
        }
        public bool AddKH(KhachHang kh)
        {
            _dbcontext.Add(kh);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAllKH()
        {
            return _dbcontext.KhachHangs.ToList();
        }

        public bool RemoveKH(KhachHang kh)
        {
            _dbcontext.Remove(kh);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool UpdateKH(KhachHang kh)
        {
            _dbcontext.Update(kh);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
