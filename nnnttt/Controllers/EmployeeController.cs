using nnnttt.DataAcess;
using nnnttt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nnnttt.Controllers
{
    class EmployeeController
    {
        private readonly AddDbContext context;
        public EmployeeController()
        {
            context = new AddDbContext();
        }

        public List<Employee> GetAllEmployees()
        {
            return context.Company.ToList();
        }

        public void CreateEmp(string name)
        {
            try
            {
                Employee employee = new Employee {Fullname = name};
                context.Company.Add(employee);
                context.SaveChanges();
                Console.WriteLine("Empolyee yaradildi!");
            }
            catch (Exception)
            {

                Console.WriteLine("Pb vare brat!");
            }
        }

        public void DeleteEmp(int id)
        {
            try
            {
                Employee employeedb = context.Company.Find(id);
                if (employeedb == null)
                {
                    Console.WriteLine("Error 404 Not Found!");
                    return;
                }
                context.Company.Remove(employeedb);
                context.SaveChanges();
                Console.WriteLine("Kk");
            }
            catch (Exception)
            {

                Console.WriteLine("Pb vare brat!");
            }
        }

        public void GetEmployeeByid(int id)
        {
            Employee employeedb = context.Company.Find(id);
            if (employeedb != null)
            {
                Console.WriteLine(employeedb.Fullname);
            }
        }

        public void FilterByName(string search)
        {
            List<Employee> emps =  context.Company.ToList();
            foreach (var item in emps)
            {
                if (item.Fullname.Contains(search))
                {
                    Console.WriteLine(item.Fullname);
                }
            }
        }
    }
}
