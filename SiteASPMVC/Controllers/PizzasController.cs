using Microsoft.AspNetCore.Mvc;
using SiteASPMVC.Models;

namespace SiteASPMVC.Controllers
{
    public class PizzasController : Controller
    {
        public static PizzaViewModel Pizza { get; set; } = new PizzaViewModel("хуй", "пизда", 2);
        public PizzasController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View(Pizza);
        }
        public IActionResult CustomPizza()
        {
            return View(Pizza);
        }
    }
}
