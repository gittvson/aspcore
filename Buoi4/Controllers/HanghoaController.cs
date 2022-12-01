using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buoi4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Http.Internal;

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
            var Hanghoa = db.Hanghoa.Include(h => h.loaihanghoa).Include(h => h.nhasanxuat).Where(h => h.Mahang == id);
            return View(Hanghoa.ToList()[0]);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateHH([Bind(include: "Mahang,Tenhang,Dongia,Donvitinh,Maloai,Mansx,Hinh")] Hanghoa hh)
        {
            db.Hanghoa.Add(hh); db.SaveChanges();
            return RedirectToAction("indexHH");
        }
        public IActionResult UpdateHH([Bind(include: "Mahang,Tenhang,Dongia,Donvitinh,Maloai,Mansx,Hinh")] Hanghoa hh)
        {
            db.Hanghoa.Update(hh); db.SaveChanges();
            return RedirectToAction("indexHH");
        }
        public IActionResult SuaHH(string id)
        {
            if (id == ")")
            {
                var hh = db.Hanghoa.Include(h => h.loaihanghoa).Include(h => h.nhasanxuat);
                return View(hh.ToList()[0]);
            }
            var Hanghoa = db.Hanghoa.Include(h => h.loaihanghoa).Include(h => h.nhasanxuat).Where(h => h.Mahang == id);
            return View(Hanghoa.ToList()[0]);
        }
        [HttpPost]
        public async Task<IActionResult> AjaxUpload(IList<IFormFile> files)
        {
            var path = "";
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", formFile.FileName);
                    var filePath = Path.GetTempFileName();

                    using (var stream = System.IO.File.Create(path))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            return Json("/images/" + files[0].FileName);
        }
        [HttpPost]
        public bool XoaHH(string id)
        {
            var deletedHH = db.Hanghoa.Include(h => h.loaihanghoa).Include(h => h.nhasanxuat).Where(h => h.Mahang == id);

            db.Hanghoa.Remove(deletedHH.ToList()[0]);
            db.SaveChanges();
            
            var Hanghoa = db.Hanghoa.Include(h => h.loaihanghoa).Include(h => h.nhasanxuat);
            return true;
        }
    }
}