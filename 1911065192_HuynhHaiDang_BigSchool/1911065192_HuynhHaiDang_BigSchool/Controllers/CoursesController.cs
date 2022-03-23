using _1911065192_HuynhHaiDang_BigSchool.Models;
using _1911065192_HuynhHaiDang_BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1911065192_HuynhHaiDang_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext _dbContext;

        // GET: Courses
        
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
        
            return View(viewModel);

        }
}

}