using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEmployeeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            Employee emp = new Employee();

            emp.EmpName = "kavin";
            emp.Empsal = 2000;
            emp.EmpId = 1;
            empList.Add(emp);
            foreach (var item in empList)
            {
                Console.WriteLine(item.Empsal);
            }

            Console.Read();
        }
    }
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Empsal { get; set; }
        
    }
}