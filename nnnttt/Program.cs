using nnnttt.Controllers;
using System;

namespace nnnttt
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeController emp = new EmployeeController();
            //Console.WriteLine("Enter employee name : ");
            //string name = Console.ReadLine();
            //emp.CreateEmp(name);
            //emp.DeleteEmp(5);
            //emp.GetEmployeeByid(null);
            emp.FilterByName("r");

            //foreach (var item in emp.GetAllEmployees())
            //{
            //    Console.WriteLine(item.Fullname);
            //}
        }
    }
}
