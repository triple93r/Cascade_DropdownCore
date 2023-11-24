using Microsoft.AspNetCore.Mvc;
using Cascd_Dpdwn.Models;
using Cascd_Dpdwn.Data;

namespace Cascd_Dpdwn.Controllers
{
    public class CountryController : Controller
    {
        private readonly ILogger<CountryController> _logger;
        private readonly ApplicationDbContext _context;


        public CountryController(ILogger<CountryController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var x = _context.tbl_Territory.ToList();
            return View(x);
        }
    }
}
