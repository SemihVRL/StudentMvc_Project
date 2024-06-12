using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciMvcWebProjesi.Models.EntityFrameWork;

namespace OgrenciMvcWebProjesi.Controllers
{
    public class KulupController : Controller
    {
        // GET: Kulup
        MvcDbOkulEntities MvcDbOkulEntities=new MvcDbOkulEntities();
        public ActionResult KulupIndex()
        {
            var kulupler = MvcDbOkulEntities.TBLKULUPLER.ToList();
            return View(kulupler);
        }
    }
}