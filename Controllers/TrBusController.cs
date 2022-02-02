using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travelingyu.Data;
using Travelingyu.Models;

namespace Travelingyu.Controllers
{
    public class TrBusController : Controller
    {
        private readonly AppDbContext _context;

        public TrBusController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Pesan()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PesanAsync(TransaksiBus data)
        {
            if (ModelState.IsValid)
            {
                data.IdTr = data.IdPelanggan.ToString();

                _context.Add(data);
                _context.SaveChanges();
                await _context.SaveChangesAsync();

                return View("Index");
            }
            return View(data);
        }
    }
}
