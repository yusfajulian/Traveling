using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travelingyu.Data;
using Travelingyu.Models;
using Travelingyu.Helper;

namespace Travelingyu.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataPelanggan()
        {
            var data = _context.Tb_Pelanggan.ToList();
            return View(data);
        }

        public IActionResult ProfilAdmin()
        {
            var data = _context.Tb_User.ToList();

            return View(data);
        }

        public IActionResult Notif()
        {
            return View();
        }
    }
}
