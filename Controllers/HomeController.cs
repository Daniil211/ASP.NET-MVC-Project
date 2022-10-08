using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult TaskFirst()
        {
            return View();
        }
        public IActionResult TaskTwo() { return View(); }
        public IActionResult TaskThird() { return View(); }

        public IActionResult Index()
        {
            return View();
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
        [HttpPost]
        public IActionResult TaskFirst(int n1)
        {
            try
            {
                if (n1 < 1)
                {
                    string message = "Что то пошло не так";
                    ViewBag.r = Convert.ToString(message);
                }
                else
                {
                    double r = 0;
                    double x1 = 1;
                    double z = -1;
                    for (int i = 0; i < n1; i++)
                    {
                        x1 = x1 + 0.1;
                        z = -z;
                        r = r + x1 * z;
                    }
                    ViewBag.r = Convert.ToString(r);
                }
                return View();
            }
            catch
            {
                ViewBag.d = "Ошибка!!!!!";
            }
            return View();
        }
        [HttpPost]
        public IActionResult TaskTwo(string Letter)
        {
            try
            {
                int n = 0;
              
                if(Letter == null)
                {
                    string message = "Что пошло не так";
                    ViewBag.d = Convert.ToString(message);
                    return View();
                }
                else
                for (int i = 0; i < Letter.Length; i++)
                {
                    if (Letter[i] == ' ')
                        n++;
                }
                ViewBag.S = Convert.ToString(n);
                
            }
            catch
            {
                ViewBag.d = "Ошибка!!!!!";
            }
            return View();
        }
        [HttpPost]
        public IActionResult TaskThird(string predl)
        {
            try
            {
                List<string> qqq = new List<string>();
                if (predl == null)
                {
                    string message = "Что то пошло не так";
                    ViewBag.d = Convert.ToString(message);
                    return View();
                }
                else if(Convert.ToInt32(predl)<0 || Convert.ToInt32(predl)> 0 || predl == null)
                {
                    string message = "Что то пошло не так";
                    ViewBag.d = Convert.ToString(message);
                    return View();
                }
                else
                 
                foreach (char c in predl)
                {
                    qqq.Add(c.ToString());
                }
                if (qqq[0] == qqq[qqq.Count - 1])
                {
                    ViewBag.Qq = "Они равны";
                }
                else { ViewBag.Qq = "Они не равны"; }
            }
            catch
            {
                ViewBag.d = "Ошибка!!!!!";
            }
                return View();
        }
    }
}