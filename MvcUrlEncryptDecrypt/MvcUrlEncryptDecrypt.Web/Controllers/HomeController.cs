using MvcUrlEncryptDecrypt.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUrlEncryptDecrypt.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void E(string id)
        {
            var result = EncryptDecryptHelper.EncryptString(id);

            Response.Write(result);
        }

        public void D(string id)
        {
            var result = EncryptDecryptHelper.DecryptString(id);

            Response.Write(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}