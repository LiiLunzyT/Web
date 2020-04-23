using BaiTap5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap3.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Confirm(HttpPostedFileBase EmpAvatar, EmpModel emp)
        {
            //Lấy thông tin từ input type=file có tên Avatar
            String postedFileName = System.IO.Path.GetFileName(EmpAvatar.FileName);

            //Lưu hình đại diện về Server
            var path = Server.MapPath("/Images/" + postedFileName);
            EmpAvatar.SaveAs(path);
            EmpModel empInfo = new EmpModel
            {
                EmpID = emp.EmpID,
                EmpName = emp.EmpName,
                EmpDoB = emp.EmpDoB,
                EmpEmail = emp.EmpEmail,
                EmpPassword = emp.EmpPassword,
                EmpDepartment = emp.EmpDepartment,
                EmpAvatar = "/Images/" + postedFileName
            };
            
            //Ghi nhận các thông tin đăng ký để hiện thị trên View Confirm
            return View(empInfo);
        }
    }
}