using databasef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace databasef.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            FootballEntity f = new FootballEntity();
            List<Football> ball=f.Footballs.ToList();
            return View(ball);

        }
    }
}