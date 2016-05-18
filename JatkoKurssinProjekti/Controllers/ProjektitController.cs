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

        public ActionResult HaeTunnit(int id)
        {
            PointSQLSrv1Entities entities = new PointSQLSrv1Entities();
            List<Tunnit> tunnit = (from tu in entities.Tunnit
                                   where tu.Projekti_id == id
                                   select tu).ToList();
            //entities.Dispose();

            List<Tuntiyhteenveto> result = new List<Tuntiyhteenveto>();
            foreach (Tunnit tuntitapahtuma in tunnit)
            {
                Tuntiyhteenveto data = new Tuntiyhteenveto();
                data.Pvm = tuntitapahtuma.Pvm.ToString();
                data.Tunnit = tuntitapahtuma.Tunnit1.ToString();
                result.Add(data);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }

}