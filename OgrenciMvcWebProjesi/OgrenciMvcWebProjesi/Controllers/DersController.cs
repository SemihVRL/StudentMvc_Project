using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciMvcWebProjesi.Models.EntityFrameWork;

namespace OgrenciMvcWebProjesi.Controllers
{
    public class DersController : Controller
    {
        // GET: Ders
        MvcDbOkulEntities MvcDbOkulEntities = new MvcDbOkulEntities();
        public ActionResult DersIndex()
        {
            var dersler = MvcDbOkulEntities.TBLDERSLER.ToList();
            return View(dersler);
           
           
        }
        

    }
}