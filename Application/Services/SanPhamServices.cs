﻿using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    
    public class SanPhamServices : ISanPhamServices
    {
        private readonly ISanPhamRepository _sanPhamRepository;
        public SanPhamServices(ISanPhamRepository sanPhamRepository)
        {
            _sanPhamRepository = sanPhamRepository;
        }
        public void themSanPham(SanPhamDTO sanPhamDTO)
        {
           // var sanPham = sanPhamDTO.MappingSanPham();
            _sanPhamRepository.themSanPham(sanPhamDTO.MappingSanPham());
        }
    }
}