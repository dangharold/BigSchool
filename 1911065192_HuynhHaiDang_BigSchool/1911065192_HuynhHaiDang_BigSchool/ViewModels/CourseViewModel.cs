using _1911065192_HuynhHaiDang_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace _1911065192_HuynhHaiDang_BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Requried]
        public string Place { get; set; }
        [Requried]
        [Futuredate]
        public string Date { get; set; }
        [Requried]
        [ValidTime]
        public string Time { get; set; }

        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public object Datetime { get;  set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}