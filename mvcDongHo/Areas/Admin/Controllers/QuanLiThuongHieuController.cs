﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuanLiThuongHieuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ThemThuongHieu()
        {
            return View();
        }
    }
}