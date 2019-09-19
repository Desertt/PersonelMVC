using PersonelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMVC.Controllers
{
    public class DepartmanController : Controller
    {
        //domain/Departman/Merhaba
      public ActionResult Merhaba()
        {
            var departman = new Departman() { Id =1,Ad="Bilgi İşlem" };
            return View();

        }
    }
}