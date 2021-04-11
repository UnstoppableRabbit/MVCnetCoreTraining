using dontTrustMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace dontTrustMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Data data = new Data();
            return View(data.vkusnyashki);
        }

        public IActionResult CurrentYum(int id)
        {
            var Yc = new YummyContext();
            var yum = (from u in Yc.Yummies
                       where u.ID == id
                       select u).First();
            return View(yum);
        }

        public IActionResult Comments(int id)
        {
            List<Comment> allComs;
            using (var Yc = new YummyContext())
            {
                allComs = (from x in Yc.Comments
                           where (x.id <= id*5)&&(x.id > (id-1)*5) 
                           select x).ToList();
            }
            return View(allComs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
