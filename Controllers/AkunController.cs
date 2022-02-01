﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Travelingyu.Data;
using Travelingyu.Models;

namespace Travelingyu.Controllers
{
    public class AkunController : Controller
    {
        private readonly AppDbContext _context;

        public AkunController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Daftar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DaftarAsync(User data)
        {
            if (ModelState.IsValid)
            {
                _context.Add(data);
                _context.SaveChanges();
                await _context.SaveChangesAsync();

                //return RedirectToAction(controllerName: "Akun", actionName: "Masuk");
                return Redirect("Masuk");
            }
            return View(data);
        }

        public IActionResult Masuk()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Masuk(User data)
        {
            //var cari = _context.Tb_User.Where( // proses pencarian
            //    bebas => 
            //    bebas.Username == data.Username 
            //    &&
            //    bebas.Password == data.Password
            //    ).FirstOrDefault(); // hanya dapat 1 data

            var username = _context.Tb_User.Where(
                        bebas =>
                        bebas.Username == data.Username
                        ).FirstOrDefault();

            if (username != null)
            {
                var password = _context.Tb_User.Where(bebas => bebas.Username == data.Username && bebas.Password == data.Password)
                    .Include(bebas2 => bebas2.Roles)
                    .FirstOrDefault(); // hanya dapat 1 data


                if (password != null)
                {
                    var daftar = new List<Claim>
                    {
                        new Claim("Username", username.Username),
                        new Claim("Role", username.Roles.Id)
                    };

                    await HttpContext.SignInAsync(
                       new ClaimsPrincipal(
                           new ClaimsIdentity(daftar, "Cookie", "Username", "Role")
                           )
                    );

                    if (username.Roles.Id == "1")
                    {
                        return RedirectToAction(controllerName: "Home", actionName: "Index");
                    }

                    return RedirectToAction(controllerName: "Home", actionName: "Index");
                }
                ViewBag.pesan = "Password Anda Salah";
                return View(data);
            }
            ViewBag.pesan = "Username Anda Salah";
            return View(data);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
