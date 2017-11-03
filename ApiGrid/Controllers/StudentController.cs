using ApiGrid.Dto;
using ApiGrid.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity.Infrastructure;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace ApiGrid.Controllers
{
    public class StudentController : ApiController
    {
        private StudentContext context = new StudentContext();


        // GET /api/customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = context.Students
            .Include(c => c.StudentDetail);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.SName.Contains(query));

            var customerDtos = customersQuery
            .ToList()
            .Select(Mapper.Map<Student, StudentDto>);

            return Ok(customerDtos);
        }

        // GET /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var stud = context.Students.SingleOrDefault(c => c.SId == id);

            if (stud == null)
                return NotFound();

            return Ok(Mapper.Map<Student, StudentDto>(stud));
        }

        // POST /api/customers
        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateCustomer(StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var student = Mapper.Map<StudentDto, Student>(studentDto);
            context.Students.Add(student);
            context.SaveChanges();

            studentDto.SId = student.SId;
            return Created(new Uri(Request.RequestUri + "/" + student.SId), studentDto);
        }

        // PUT /api/customers/1
        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateCustomer(int id, StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var studentInDb = context.Students.SingleOrDefault(c => c.SId == id);

            if (studentInDb == null)
                return NotFound();

            Mapper.Map(studentDto, studentInDb);

            context.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/1
        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var studentInDb = context.Students.SingleOrDefault(c => c.SId == id);

            if (studentInDb == null)
                return NotFound();

            context.Students.Remove(studentInDb);
            context.SaveChanges();

            return Ok();
        }


        /*public HttpResponseMessage Get()
        {
            using (StudentContext db = new StudentContext())
            {
                List userlist = new List();
                userlist = db.StudentViewModels.OrderBy(a => a.SId).ToList();
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, userlist);
                return response;
            }
        }*/


    }
}
