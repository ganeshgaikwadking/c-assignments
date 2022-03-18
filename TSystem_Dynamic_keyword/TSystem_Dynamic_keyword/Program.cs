using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Dynamic_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Dynamic Keyword================");
            dynamic j;
            j = 87;
            Console.WriteLine(j);
            j = "TSystem";
            Console.WriteLine(j);
            j = false;
            Console.WriteLine(j);
            j = 90.879f;
            Console.WriteLine(j);

            Employee objEmployee = new Employee();
            objEmployee.EmpInfo();
            Console.WriteLine("=======Now Changing The Values=====");
            objEmployee.empName = "joe";
            Console.WriteLine($"Emp Name ::{objEmployee.empName}");

            objEmployee.empName = true;
            Console.WriteLine($"Emp Name ::{objEmployee.empName}");

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public dynamic empId;
        public dynamic empName = "Ganesh";

        public void EmpInfo()
        {
            empId = 90;
            Console.WriteLine($"Emp Id ::{empId}");
            Console.WriteLine($"Emp Name ::{empName}");

        }
        //public dynamic EmpInformation()
        //{
        //    return empName;
        //}
    
    
    }

}
