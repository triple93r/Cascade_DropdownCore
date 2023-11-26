using Cascd_Dpdwn.Data;
using Cascd_Dpdwn.Models;
using Cascd_Dpdwn.VMs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace Cascd_Dpdwn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DisplayData()
        {
            AllTbl allTbl = new AllTbl();
            allTbl.tbl_Territory = _context.tbl_Territory.ToList();
            //allTbl.tbl_Country = _context.tbl_Country.ToList();
            //allTbl.tbl_Stt =  _context.tbl_Stt.ToList();
            
            return View(allTbl);
        }

        [HttpPost]
        public ActionResult GetCountry(int id)
        {
            var response = _context.tbl_Country.Where(x => x.Ter_id == id).ToList();
            return Json(response);
        }

        [HttpPost]
        public ActionResult GetState(int id)
        {
            var response = _context.tbl_Stt.Where(x => x.Cnt_id == id).ToList();
            return Json(response);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}