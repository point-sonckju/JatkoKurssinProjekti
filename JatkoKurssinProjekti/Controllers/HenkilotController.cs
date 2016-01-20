using JatkoKurssinProjekti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JatkoKurssinProjekti.Controllers
{
    public class HenkilotController : Controller
    {
        // GET: Henkilot
        public ActionResult Index()
        {
            PointSQLSrv1Entities entities = new PointSQLSrv1Entities();
            List<Henkilot> model = entities.Henkilot.ToList();
            entities.Dispose();

            return View(model);
        }
    }
}