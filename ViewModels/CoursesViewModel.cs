using VoXuanTu_BigSchool001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoXuanTu_BigSchool001.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}