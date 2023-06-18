using MVCEgitim.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC14FiltersController : Controller
    {
        // GET: MVC14Filters
        [UserControl]
    // bizim yazdığımız fitreyi ekledik böylece aşağıdaki index metoduna bir istek geldiğinde bir kontrol yapılacak ve UserControl içerisinde uyguladığımız şart yerine geliyorsa ekran açılacak aksi takdirde yine login sayfasına yönlendirilecek
        public ActionResult Index()
        {
            return View();
        }
    }
}