using BigSchool.DTOs;
using BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext cdbcontext;
        public AttendancesController()
        {
            cdbcontext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userid = User.Identity.GetUserId();
            if (cdbcontext.Attendances.Any(a => a.AttendeeId == userid && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Attendance already exists!");
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userid
            };
            cdbcontext.Attendances.Add(attendance);
            cdbcontext.SaveChanges();
            return Ok();
        }
    }
}
