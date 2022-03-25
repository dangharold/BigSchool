using _1911065192_HuynhHaiDang_BigSchool.Models;
using System;
using System.Collections.Generic;

namespace _1911065192_HuynhHaiDang_BigSchool.Controllers
{
    internal class ApplicationDbContext_dbContext
    {
        public IEnumerable<object> Followings { get; internal set; }
        public IEnumerable<object> Attendances { get; internal set; }
        public object Courses { get; internal set; }

        public static implicit operator ApplicationDbContext_dbContext(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}