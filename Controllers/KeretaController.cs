using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travelingyu.Data;

namespace Travelingyu.Controllers
{
    public class KeretaController : Controller
    {
        private readonly AppDbContext _context;

        public KeretaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Tb_Kereta.ToList();
            return View(data);
        }
    }
}
