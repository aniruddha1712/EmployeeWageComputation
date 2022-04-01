using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmpWageComputation
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmpWageObject Dmart = new EmpWageObject("Dmart", 25, 20, 80);
            EmpWageObject Mahindra = new EmpWageObject("Mahindra", 30, 22, 90);
            EmpWageObject Nvidia = new EmpWageObject("Nvidia", 40, 25, 100);
            Dmart.ComputeEmpWage();
            Console.WriteLine(Dmart.toString());
            Mahindra.ComputeEmpWage();
            Console.WriteLine(Mahindra.toString());
            Nvidia.ComputeEmpWage();
            Console.WriteLine(Nvidia.toString());

            Console.ReadLine();
        }
    }
}
         
