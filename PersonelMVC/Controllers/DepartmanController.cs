using PersonelMVC.Models;
using System.Web.Mvc;

namespace PersonelMVC.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Detay(int id)
        {
            ViewData["departmanId"] = id;
            return View();
        }
    }
}