using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PersonelMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //Kendi URL mizi oluşturalım...

            routes.MapMvcAttributeRoutes();  //--Route Attribute Kullanımı Daha Faydalıdır.Büyüyen RouteConfig sayfasını karmaşıklığını çözer.

            //routes.MapRoute(
            //    name: "Anasayfa",
            //    url: "",
            //    defaults: new { controller = "Departman", action = "Merhaba"}
            //);

            //routes.MapRoute(
            //    name: "Personel",
            //    url: "personel/liste/{siralama}/{sayfa}",
            //    defaults: new { controller = "Personel", action = "PersonelListesi" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{depatmanid}",
                defaults: new { controller = "Home", action = "Index", depatmanid = UrlParameter.Optional }
            );
        }
    }
}
