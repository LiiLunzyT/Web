using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap2.Models;

namespace BaiTap2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Information()
        {
            ViewBag.Id = "N/A";
            ViewBag.Name = "N/A";
            ViewBag.Mark = "N/A";
            return View();
        }

        public ActionResult RegisterRequest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterRequest(string f)
        {
            ViewBag.Id = Request["Id"];
            ViewBag.Name = Request["Name"];
            ViewBag.Mark = Request["Mark"];
            ViewBag.BackURL = "/Student/RegisterRequest";

            return View("Information");
        }

        public ActionResult RegisterArguments()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterArguments(string Id, String Name, double Mark)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Mark = Mark;
            ViewBag.BackURL = "/Student/RegisterArguments";

            return View("Information");
        }

        public ActionResult RegisterFormCollection()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterFormCollection(FormCollection f)
        {
            ViewBag.Id = f["Id"];
            ViewBag.Name = f["Name"];
            ViewBag.Mark = double.Parse(f["Mark"]);
            ViewBag.BackURL = "/Student/RegisterFormCollection";

            return View("Information");
        }

        public ActionResult RegisterModel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterModel(StudentModel s)
        {
            ViewBag.Id = s.Id;
            ViewBag.Name = s.Name;
            ViewBag.Mark = s.Mark;
            ViewBag.BackURL = "/Student/RegisterModel";

            return View("Information");
        }
    }
}