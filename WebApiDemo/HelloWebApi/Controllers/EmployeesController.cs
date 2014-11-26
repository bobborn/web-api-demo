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


        // GET api/employees
        public IEnumerable<Employee> Get()
        {
            return list;
        }

        // GET api/employees/12345
        public Employee Get(int id)
        {
            return list.First(e => e.Id == id);
        }

        // POST api/employees
        public void Post(Employee employee)
        {
            int maxId = list.Max(e => e.Id);
            employee.Id = maxId + 1;
            list.Add(employee);
        }

        // PUT api/employees/12345
        public void Put(int id, Employee employee)
        {
            int index = list.ToList().FindIndex(e => e.Id == id);
            list[index] = employee;
        }

        // DELETE api/employees/12345
        public void Delete(int id)
        {
            Employee employee = Get(id);
            list.Remove(employee);
        }
    }
}
