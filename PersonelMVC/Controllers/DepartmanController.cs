using System.Web.Mvc;

namespace PersonelMVC.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Detay(int? id)
        {
            if (id.HasValue)

                ViewData["departmanId"] = id.Value;
            else

                ViewData["departmanId"] = 0;

            return View();
        }
    }
}