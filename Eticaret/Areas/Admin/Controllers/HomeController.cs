using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eticaret.Infrastructure;
namespace Eticaret.Areas.Admin.Controllers
{
    [SelectedTab("Home")]
    public class HomeController : Controller
    {
        private Entitie context = new Entitie(); 
        // GET: Admin/Home
        
        public ActionResult List()
        {
            context.GetType();
            return View();
        }
    }
}