using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Szakdolgozat01.Models;


namespace Szakdolgozat01.Controllers
{
    public class AsztalController : Controller
    {

        // GET: Asztal
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Asztalterkep()
        {
            var viewModelList = new List<AsztalViewModel>();

            viewModelList.Add(new AsztalViewModel { Szam = 1, Nev = "Kis Pista", Idopont = new DateTime(2021,04,21,19,00,00) });
            viewModelList.Add(new AsztalViewModel { Szam = 1, Nev = "Kovács Béla", Idopont = new DateTime(2021, 04, 15, 19, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 2, Nev = "Kakszi Lajos", Idopont = new DateTime(2021, 04, 02, 19, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 3, Nev = "Nagy Benedek", Idopont = new DateTime(2021, 04, 13, 19, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 4, Nev = "Erős Laci", Idopont = new DateTime(2021, 04, 27, 17, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 11, 17, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 13, 17, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 1, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 16, 17, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 21, 13, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 21, 13, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 3, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 21, 13, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 21, 13, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 23, 11, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Antal Géza", Idopont = new DateTime(2021, 04, 23, 11, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 3, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 23, 11, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 23, 21, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 10, 19, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 1, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 10, 11, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 10, 15, 00, 00) });
            viewModelList.Add(new AsztalViewModel { Szam = 5, Nev = "Jóska Géza", Idopont = new DateTime(2021, 04, 10, 13, 00, 00) });



            return View(viewModelList.OrderBy(x=>x.Szam).ThenBy(y=>y.Idopont.Hour));
        }
        public ActionResult Foglalas()
        {
            var szabadIdopontok = new List<FoglalasViewModel>();
            szabadIdopontok.Add(new FoglalasViewModel { Idopont = 11 });
            szabadIdopontok.Add(new FoglalasViewModel { Idopont = 11 });
            szabadIdopontok.Add(new FoglalasViewModel { Idopont = 11 });
            szabadIdopontok.Add(new FoglalasViewModel { Idopont = 13 });
            szabadIdopontok.Add(new FoglalasViewModel { Idopont = 15 });
            szabadIdopontok.Add(new FoglalasViewModel { Idopont = 17 });
            szabadIdopontok.Add(new FoglalasViewModel { Idopont = 21 });
            szabadIdopontok.Add(new FoglalasViewModel { Idopont = 17 });

            
            

            return View(szabadIdopontok.OrderBy(x=>x.Idopont));
        }
    }



}
