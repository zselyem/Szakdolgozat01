using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Szakdolgozat01.Models;
using System.Data.Entity;


namespace Szakdolgozat01.Controllers
{
    public class AsztalController : Controller
    {
        private ApplicationDbContext _context;

        public AsztalController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        // GET: Asztal
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Asztalterkep()
        {
            
            var asztalok = _context.Foglalasok.OrderBy(x => x.Idopont);            
                

           return View(asztalok);
        }
        public ActionResult Foglalas()
        {
            var foglalas = new Foglalas();

            
            

            return View(foglalas);
        }
    }



}
