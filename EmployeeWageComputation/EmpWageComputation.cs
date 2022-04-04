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

            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Dmart", 25, 20, 80);
            empWageBuilder.addCompanyEmpWage("Mahindra", 30, 22, 90);
            empWageBuilder.addCompanyEmpWage("Nvidia", 40, 25, 100);
            empWageBuilder.computeEmpWage();

            Console.ReadLine();
        }
    }
}
         
