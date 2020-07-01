using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using firsttimetomeetcsharp.Models;

namespace firsttimetomeetcsharp.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public StudentsController()
        {
        }

        // GET api/students
        [HttpGet("all")]
        public ActionResult<IEnumerable<string>> Getstrings()
        {
            return new List<string> { "hello" };
        }

        // GET api/students/5
        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return id.ToString();
        }

        // POST api/students
        [HttpPost("")]
        public void Poststring(string value)
        {
        }

        // PUT api/students/5
        [HttpPut("{id}")]
        public void Putstring(int id, string value)
        {
        }

        // DELETE api/students/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
        }
    }
}