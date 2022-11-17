using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buoi4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Buoi4.Controllers
{
    public class HanghoaController : Controller
    {
        private QLBHContext db = new QLBHContext();
        public IActionResult indexHH()
        {
            var Hanghoa = db.Hanghoa.Include(h => h.loaihanghoa).Include(h => h.nhasanxuat);
            return View(Hanghoa.ToList());
        }
        public IActionResult xemHH(string id)
        {
            var Hanghoa = db.Hanghoa.Include(h => h.loaihanghoa).Include(h => h.nhasanxuat).Where(h=> h.Mahang == id);
            return View(Hanghoa.ToList()[0]);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
    
}
