﻿using DAL1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interfaces
{
    public interface Interface_DichVu
    {
        List<DichVu> TaiDuLieu();
        public DichVu Them_Moi(DichVu DuLieu);
        public void Cap_Nhat(DichVu MucTieu);
        public void Xoa(DichVu MucTieu);
    }
}
