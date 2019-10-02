using PersonelMVC.Models;
using System.Web.Mvc;

namespace PersonelMVC.Controllers
{
    public class DepartmanController : Controller
    {
        ////domain/Departman/Merhaba
        //public ActionResult Merhaba()
        //{
        //    var departman = new Departman() { Id = 1, Ad = "Bilgi İşlem" };
        //    return View(departman);

        //}

        //public ActionResult Test()
        //{

        //    /*ACTION RESULT TİPLERİ*/
        //    /*return new ViewResult();*/
        //    /*ViewResult da kullanılabilir.ViewResult,ActionResult'tan kalıtım almış bir sınıftır. 
        //    ViewResult kullanırsan geriye View türüne birşey döndürmen gerekir ama 
        //    Json, JavaScriptResult, RedirectToAction vs. döndürmezsin.*/
        //    return View();
        //    /*ActionResult base class olduğundan bunda istediğini döndürebilirsin.
        //     * Ancak örnek vermek gerekirse  Json döndürüyorsan actionunun tipini JsonResult
        //     * yapman o sınıfta özgü metodlarını kullanmanı sağlayacaktır. 
        //     * Geriye return View() yazıp yapıyorsan çok birşey fark etmiyor*/

        //    /*return Content("Content Result");
        //     * Bir MVC projesinde kullanıcı tanımlı verileri son kullanıcıya döndüren metotlara denir.
        //     * Kullanıcı tarafına view kullanmadan içerik dönderebilirsiniz.*/

        //    /*return HttpNotFound();
        //     * 404 durum kodu döndererek aranılan içeriğin bulunmadığını belirtebilirsiniz.*/

        //    /*Json tipinde bir result döndürmek istediğimizde 
        //    var departman = new Departman() { Id = 1, Ad = "Bilgi İşlem" };
        //    return Json(departman, JsonRequestBehavior.AllowGet); */

        //    /*Boş döndürmek için Empty Result Kullanılabilir.Adı üstünde boş yani hiçbir sonuç döndürmemektedir.
        //    return new EmptyResult();*/

        //    /*return Redirect("http://www.duvarkagitankara.com");
        //     HTTP yönlendirmesi ile yeni bir siteye yönlendirmek için kullanılır*/

        //    /*return RedirectToAction("Index", "Personel"); --PersonleController'ın Index Metoduna Bağlı 
        //     * Content Result'ı Döndürür*/

        //    /*return RedirectToAction("Index", "Personel",new {SortBy= "Maas"}); --Parametre gönderdik */




        //}

        ////Controller'a GET ile parametre gönderme
        ///*Bir departman silmek istiyorum bunun için controller'a bu silinecek departmanın ID sini parametre
        // olarak göndermem gerekiyor.*/

        ////Controller'a Get ile Parametre Gönderme
        //public ActionResult Sil(int id)
        //{
        //    return Content("Gelen Id: " + id);  
            
        //    /*NOT:Departman/Sil/5 veya queryString ile de gönderilebilir.
        //    Departman/Sil?5 */


        //}

        //public ActionResult Update(int depatmanid, string ad)
        //{
        //    return Content("Depatman Id: " + depatmanid + " && Ad: " + ad);

        //}

        public ActionResult Detay(int id)
        {
            var departman = new Departman() { Id = id, Ad = "Bilgi İşlem" };
            ViewData["departman"] = departman;
            return View(departman);//geriye html döndüreceğimizi belirtiyoruz
        }

    }
}