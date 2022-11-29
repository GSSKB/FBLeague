using FootBallLeagueMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootBallLeagueMVC.Controllers
{
    public class HomeController : Controller
    {
        Database1 db=new Database1();

        [HttpGet]
        public ActionResult AddMatchResult()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMatchResult(FbLeague fbl)
        {
            db.FbLeagues.Add(fbl);
            db.SaveChanges();
            return RedirectToAction("Index1");
           
        }
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult List()
        {
            List<FbLeague> list = db.FbLeagues.ToList();

            return View(list);
        }


    }
}
