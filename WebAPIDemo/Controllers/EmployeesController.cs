using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        public static List<Employee> EmployeesList = new List<Employee>
        {
            new Employee {ID = 1001, Name = "Abhishek Yadav", City = "Jaipur", IsActive = true},
            new Employee {ID = 1002, Name = "Ahmad Kumar", City = "New Delhi", IsActive = true},
            new Employee {ID = 1003, Name = "John Doe", City = "New York", IsActive = true},
            new Employee {ID = 1004, Name = "Mohan Kumar", City = "Noida", IsActive = false},
            new Employee {ID = 1005, Name = "Akash Kumar", City = "Chennai", IsActive = true},
        };

        //GET : api/Employees
       public List<Employee> Get()
        {
            return EmployeesList;
        }
        
        //Get : api/Employees/1001

        public Employee Get(int Id)
        {
            return EmployeesList.FirstOrDefault(e => e.ID == Id);
        }

        //POST : api/Employees

        public void Post(Employee employee)
        {
            EmployeesList.Add(employee);
        }

        //PUT : api/Employees/1001

        public void Put(int id, Employee employee)
        {
            var emp = EmployeesList.FirstOrDefault(e => e.ID == id);
                if(emp != null)
            {
                emp.Name = employee.Name;
                emp.City = employee.City;
                emp.IsActive = employee.IsActive;   
            }
        }

        //DELETE : api/Employees/1001

        public void Delete(int id)
        {
            var emp = EmployeesList.FirstOrDefault(e => e.ID == id);
            {
                if(emp != null)
                {
                    EmployeesList.Remove(emp);
                }
            }

        }

    }
}
