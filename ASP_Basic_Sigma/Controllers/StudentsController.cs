
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Basic_Sigma.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Basic_Sigma.Controllers
{

    //v.1 [Route("api/v2/Students")]
    //v.2 [Route("api/v2/[controller]")]
    public class StudentsController: ControllerBase
    {
        //v.1 [Route("[action]")]
        //v.2 [Route("GetStudent")]

        [HttpGet]
        public Student GetStudentById([FromQuery]int id)
        {
            return new Student() { };
        }

        [HttpPost]
        public string Update([FromBody]Student student)
        {
            return "ok";
        }

        //[Route("[action]")]
        //public string GetStudent2()
        //{
        //    return "Hello Student2";
        //}

    }
}
