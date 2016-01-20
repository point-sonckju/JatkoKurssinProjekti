using JatkoKurssinProjekti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JatkoKurssinProjekti.Controllers
{
    public class ProjektitController : Controller
    {
        // GET: Projektit
        public ActionResult Index()
        {
            PointSQLSrv1Entities entities = new PointSQLSrv1Entities();
            List<Projektit> model = entities.Projektit.ToList();
            entities.Dispose();
            
            return View(model);
        }
    }
}