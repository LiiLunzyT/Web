using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap5.Controllers
{
    public class BannerController : Controller
    {
        // GET: Banner
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangeBanner(HttpPostedFileBase banner)
        {
            String postedFileName = System.IO.Path.GetFileName(banner.FileName);
            var path = Server.MapPath("/Images/" + postedFileName);
            banner.SaveAs(path);
            String fSave = Server.MapPath("/banner.txt");
            System.IO.File.WriteAllText(fSave, postedFileName);

            return View("Index");
        }
    }
}