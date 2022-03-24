using _1911065192_HuynhHaiDang_BigSchool.Models;
using _1911065192_HuynhHaiDang_BigSchool.ViewModels;
using Microsoft.AspNet.Identity;
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
        [Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
          

            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place,
            };
            _dbContext.Cources.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");

        }
}

}