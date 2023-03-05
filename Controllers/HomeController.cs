using Microsoft.AspNetCore.Mvc;

namespace MvcViewsLayoutApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Works()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(string username, 
                                    int age, 
                                    string comment,
                                    string married,
                                    string skill,
                                    string[] city)
        {
            ViewBag.Name = username;
            ViewBag.Age = age;
            ViewBag.Comment = comment;
            ViewBag.Married = married;
            ViewBag.Skill = skill;
            ViewBag.City = city;

            return View("UserInfo");
        }
            
    }
}
