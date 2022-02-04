using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Travelingyu.Data;
using Travelingyu.Models;

namespace Travelingyu.Controllers
{
    public class BusController : Controller
    {
        private readonly AppDbContext _context;

        public BusController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Tb_Bus.ToList();
           
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pelanggan data)
        {
            if (ModelState.IsValid)
            {
                data.KodePelanggan = data.NomorKtp.ToString();

                _context.Add(data);
                _context.SaveChanges();
                await _context.SaveChangesAsync();

                return View("Pesan");
            }
            return View(data);
        }

        public async Task<IActionResult> PesanAsync(TransaksiBus data)
        {
            if (ModelState.IsValid)
            {
                data.IdTr = "1";

                _context.Add(data);
                _context.SaveChanges();
                await _context.SaveChangesAsync();
            }
            return View(data);
        }
    }
}
