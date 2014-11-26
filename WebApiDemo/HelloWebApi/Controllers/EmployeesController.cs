using HelloWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebApi.Controllers
{
    public class EmployeesController : ApiController
    {
        private static IList<Employee> list = new List<Employee>()
        {
            new Employee()
            {
                Id = 12345, FirstName = "John", LastName = "Human"
            },
            new Employee()
            {
                Id = 12346, FirstName = "Jane", LastName = "Public"
            },
            new Employee()
            {
                Id = 12347, FirstName = "Joseph", LastName = "Law"
            }
        };
    }
}
