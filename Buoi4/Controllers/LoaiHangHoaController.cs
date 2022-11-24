using Buoi4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace Buoi4.Controllers
{
    public class LoaiHangHoaController : Controller
    {
        private QLBHContext db = new QLBHContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public Object getLoaiHangHoa()
        {
            return db.Loaihanghoa.ToList();
        }
    }
}
