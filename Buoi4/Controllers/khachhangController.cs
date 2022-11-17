using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buoi4.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Buoi4.Controllers
{
    public class khachhangController : Controller
    {
        
        private QLBHContext db = new QLBHContext();
        // GET: khachhang
        public ActionResult indexDangNhap()
        { 
            ViewBag.kiemtraDangnhap = null;
            return View();
        }
    }

}
