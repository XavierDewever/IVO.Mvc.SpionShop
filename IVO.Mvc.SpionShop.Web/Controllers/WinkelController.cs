using IVO.Mvc.SpionShop.Web.Models;
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
            List<Categorie> catlist = new List<Categorie>
            {
            new Categorie { Naam = "Algemeen" },
            new Categorie { Naam = "Afleiding" },
            new Categorie { Naam = "Communicatie" }
            };

            return View(catlist);
        }

        // GET: /Winkel/Producten
        public ActionResult Producten(string categorie)
        {
            Categorie cat = new Categorie { Naam = categorie };
            return View(cat);
        }

        // GET: /Winkel/Details/7
        public ActionResult Details(int id)
        {
            var product = new Product { Naam = "Product nummertje " + id };
            return View(product);
        }
    }
}