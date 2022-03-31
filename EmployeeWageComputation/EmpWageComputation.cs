using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmpWageComputation
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
     
        public static void ComputeEmpWage(string company,int empRatePerHr,int numOfWorkingDays,int maxWorkingHrs)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int empHrs = 0, empWage = 0, totalWorkingHrs = 0, totalWorkingDays = 1;

            while (totalWorkingDays <= numOfWorkingDays && totalWorkingHrs <= maxWorkingHrs)

            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalWorkingHrs += empHrs;
                if (totalWorkingHrs > maxWorkingHrs)
                {
                    totalWorkingHrs -= empHrs;
                    break;
                }
                Console.WriteLine("day: " + totalWorkingDays + " working hrs: " + empHrs);
                totalWorkingDays++;
            }
            int totalEmpWage = totalWorkingHrs * empRatePerHr;
            Console.WriteLine("{0} Employee had worked for {1} hrs in {2} days and earned {3} rs",company, totalWorkingHrs, totalWorkingDays - 1, totalEmpWage);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("Dmart",25,20,80);
            ComputeEmpWage("Mahindra",30,22,90);
            ComputeEmpWage("Nvidia",40,25,100);
        }
    }
}
         
