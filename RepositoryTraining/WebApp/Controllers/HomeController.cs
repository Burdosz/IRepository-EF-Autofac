using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRepository.Interfaces;
using WebAppRepository.Repositories;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IStudentRepository studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ActionResult Index()
        {
            return View();
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