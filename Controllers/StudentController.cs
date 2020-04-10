using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularWebApi.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<string> studentslist = new List<string>()
        {
            "Ravi","Dilip","Anurag","Arshi","Divya","Danish"
        };
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return studentslist;
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return studentslist[id];
        }
    }
}