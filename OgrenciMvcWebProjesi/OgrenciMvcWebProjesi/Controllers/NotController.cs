using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciMvcWebProjesi.Models.EntityFrameWork;

namespace OgrenciMvcWebProjesi.Controllers
{
    public class NotController : Controller
    {
        // GET: Not
        MvcDbOkulEntities MvcDbOkulEntities=new MvcDbOkulEntities();
        public ActionResult NotIndex()
        {
            var notlar = MvcDbOkulEntities.TBLNOTLAR.ToList();
            return View(notlar);
        }
    }
}