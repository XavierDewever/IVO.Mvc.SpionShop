using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IVO.Mvc.SpionShop.Web.Controllers
{
    public class WinkelController : Controller
    {
        // GET: Winkel
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Winkel/Producten
        public ActionResult Producten(string categorie)
        {
            return View();
        }

        // GET: /Winkel/Details
        public ActionResult Details()
        {
            return View();
        }
    }
}