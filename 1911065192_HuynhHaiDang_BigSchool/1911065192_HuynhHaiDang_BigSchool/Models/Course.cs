﻿using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1911065192_HuynhHaiDang_BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        [StringLength(255)]
        public string LecturerId { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
    }
}