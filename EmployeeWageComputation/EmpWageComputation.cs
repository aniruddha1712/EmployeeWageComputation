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

            EmpWageArray empWageArray = new EmpWageArray();
            empWageArray.addCompanyEmpWage("Dmart", 25, 20, 80);
            empWageArray.addCompanyEmpWage("Mahindra", 30, 22, 90);
            empWageArray.addCompanyEmpWage("Nvidia", 40, 25, 100);
            empWageArray.computeEmpWage();

            Console.ReadLine();
        }
    }
}
         
