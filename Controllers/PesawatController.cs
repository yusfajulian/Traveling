﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travelingyu.Data;
using Travelingyu.Models;

namespace Travelingyu.Controllers
{
    public class PesawatController : Controller
    {
        private readonly AppDbContext _context;

        public PesawatController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Tb_Tujuan.Where(bebas => bebas.Jenis == "Pesawat");
            return View(data);
        }
    }
}
