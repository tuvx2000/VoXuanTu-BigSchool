using VoXuanTu_BigSchool001.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VoXuanTu_BigSchool001.Controllers.Api
{
    public class CoursesController : ApiController
    {
        public ApplicationDbContext _dnContext { get; set; }
        public CoursesController()
        {
            _dnContext = new ApplicationDbContext();
        }
        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dnContext.Courses.Single(c => c.Id == id && c.LectureId == userId);
            if (course.IsCanceled)
                return NotFound();
            course.IsCanceled = true;
            _dnContext.SaveChanges();
            return Ok();
        }
    }
}
