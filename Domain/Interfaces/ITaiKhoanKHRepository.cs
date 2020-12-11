﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITaiKhoanKHRepository
    {
         IEnumerable<TaiKhoanKH> getAll();
        public TaiKhoanKH TimTK(string TaiKhoan, string MatKhau, string IDKhachHang);
        public void ThemTK(TaiKhoanKH taiKhoanKH);

    }
}
