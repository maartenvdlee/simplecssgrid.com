using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class DocsController : Controller
    {
        //
        // GET: /Docs/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Demo(int? id)
        {
            if (id.HasValue && (id == 720 || id == 960 || id == 1080 || id == 1200))
                ViewBag.GridSize = id.Value;

            return View();
        }

    }
}
