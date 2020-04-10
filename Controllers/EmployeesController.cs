using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using AngularWebApi.Models;

namespace AngularWebApi.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        static List<Employee> emplist = new List<Employee>()
        {
           new Employee{EmpId=1,EmpName="Palak",EmpDesig="Manager"},
           new Employee{EmpId=2,EmpName="Kareena",EmpDesig="HR"},
           new Employee{EmpId=3,EmpName="Pushp",EmpDesig="Developer"},

        };
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return emplist;
        }
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return emplist[id];
        }
    }
}