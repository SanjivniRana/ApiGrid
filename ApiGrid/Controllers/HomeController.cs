using ApiGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiGrid.Controllers
{
    public class HomeController : Controller
    {

        StudentContext context = new StudentContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        /*public ActionResult GetData()
         {
             using (StudentContext db = new StudentContext())
             {

                 var StudentData = db.students.OrderBy(a => a.Id).ToList();
                 //var StudentDetailsData = db.studentDetails.OrderBy(a => a.RollNo).ToList();
                 var StudentDetailsData = db.studentDetails.OrderBy(a => a.Id).ToList();
                 return Json(new { data = StudentDetailsData }, JsonRequestBehavior.AllowGet);


             }
         }*/
    }
}