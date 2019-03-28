using BigSchool.Models;
using BigSchool.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        public CoursesController()
        {
            dbcontext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel()
            {
                Categories = dbcontext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}