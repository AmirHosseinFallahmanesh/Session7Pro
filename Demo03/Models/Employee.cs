using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo03.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }

    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
    public class FakeRepository: IEmployeeRepository
    {
       public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId=1,
                    Name="ali",
                    Surname="alavi"
                },
                        new Employee()
                {
                    EmployeeId=2,
                    Name="reza",
                    Surname="rezaii"
                },
            };
        }
    }
}
