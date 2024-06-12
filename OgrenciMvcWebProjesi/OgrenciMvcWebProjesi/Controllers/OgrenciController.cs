using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciMvcWebProjesi.Models.EntityFrameWork;

namespace OgrenciMvcWebProjesi.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        MvcDbOkulEntities MvcDbOkulEntities=new MvcDbOkulEntities();
        public ActionResult OgrenciIndex()
        {
            var ogrenci = MvcDbOkulEntities.TBLOGRENCILER.ToList();
            return View(ogrenci);
        }
    }
}