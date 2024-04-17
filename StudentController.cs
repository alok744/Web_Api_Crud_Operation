using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace webapi_core_crud_operation.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> obj_student = new List<Student>();
        // GET: StudentController
        [HttpGet("/id")]
        public IEnumerable<Student> GetAll()
        {
            return obj_student;
        }

        // GET: StudentController/Details/5
        [HttpGet("/id")]
        public Student Get(int id)
        {
            return obj_student.FirstOrDefault(s=>s.studentid==id);
        }

        // GET: StudentController/Create
        [HttpPost("/id")]
        public IEnumerable<Student> post(Student id)
        {
            obj_student.Add(id); 
            return obj_student;
        }

        // GET: StudentController/Edit/5
        [HttpPut("/id")]
        public void Edit(int id,Student value)
        {
            int i = obj_student.FindIndex(s => s.studentid == id);
            if(i>=0)
            {
                obj_student[i] = value;
            }
            
        }


        // GET: StudentController/Delete/5
        [HttpDelete("/id")]
        public void Delete(int id)
        {
            obj_student.RemoveAll(s=>s.studentid==id);
        }

        
    }
}
