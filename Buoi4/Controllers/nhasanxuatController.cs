using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buoi4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Buoi4.Controllers
{
    public class nhasanxuatController : Controller
    {
        private QLBHContext db = new QLBHContext();
        public IActionResult Index()
        {
            return View(db.Nhanvien);
        }
        public ActionResult themNSX()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult themNSX([Bind(include: "Masx,Tensx,Diachi,Hanghoa")] Nhasanxuat nhasanxuat)
        {
            db.Nhasanxuat.Add(nhasanxuat); db.SaveChanges();
            return RedirectToAction("indexNV");
        }

        [HttpGet]
        public Object getNSX()
        {
            return db.Nhasanxuat.ToList();
        }


    }
}