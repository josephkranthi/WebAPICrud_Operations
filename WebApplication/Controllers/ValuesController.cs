using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IHttpActionResult GetAllStudentsWithAddress()
        {
            IList<TeacherViewModel> students = null;

            using (var ctx = new EF_Demo_DBEntities1())
            {
                students = ctx.Teachers.Select(s => new TeacherViewModel()
                {
                    TeacherId = s.TeacherId,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                }).ToList<TeacherViewModel>();
            }


            if (students.Count == 0)
            {
                return NotFound();
            }

            return Ok(students);
        }
        // GET api/values/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            IList<TeacherViewModel> students = null;


            using (var ctx = new EF_Demo_DBEntities1())
            {
                students = ctx.Teachers.Select(s => new TeacherViewModel()
                {
                    TeacherId = s.TeacherId,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                }).ToList<TeacherViewModel>();
            }
            var student = students.Where(e => e.TeacherId == id);
            if (student != null)
                return Ok(student);
            else
            {
                return null;
            }

        }

        // POST api/values  //[Route("api/student/names")]
        [HttpPost]
       
        public IHttpActionResult PostNewStudent(string FirstName, string LastName)
        {
         

            using (var ctx = new EF_Demo_DBEntities1())
            {
                
                ctx.Teachers.Add(new Teacher()
                {
                
                    FirstName = FirstName,
                    LastName =  LastName
                });

                ctx.SaveChanges();
            }

            return Ok("success");
        }

        // PUT api/values/5
        [HttpPut]
        public IHttpActionResult Put( int id ,string FirstName, string LastName)
        {
            if (id <= 0)
                return null;

            using (var ctx = new EF_Demo_DBEntities1())
            {
                var existingStudent = ctx.Teachers.Where(s => s.TeacherId == id)
                                                        .FirstOrDefault();

                if (existingStudent != null)
                {
                    existingStudent.FirstName = FirstName;
                    existingStudent.LastName = LastName;

                    ctx.SaveChanges();

                    return Ok("success");
                }
                else
                {
                    return null;
                }
            }

        }
        [HttpDelete]
        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return null;

            using (var ctx = new EF_Demo_DBEntities1())
            {
                var student = ctx.Teachers
                    .Where(s => s.TeacherId == id)
                    .FirstOrDefault();
                if (student != null)
                {
                    ctx.Teachers.Remove(student);
                    ctx.SaveChanges();
                    return Ok("Success");
                }
                else
                {
                    return null;
                }

            }

        }
    }
}
