using JatkoKurssinProjekti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JatkoKurssinProjekti.Controllers
{
    public class TunnitController : Controller
    {
        // GET: Tunnit
        public ActionResult Index()
        {
            PointSQLSrv1Entities entities = new PointSQLSrv1Entities();
            List<Tunnit> model = entities.Tunnit.ToList();
            entities.Dispose();

            return View(model);
        }
    }
}