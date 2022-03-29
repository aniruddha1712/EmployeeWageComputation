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
            public const int EMP_RATE_PER_HR = 20;
            public const int NUM_OF_WORKING_DAYS = 20;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int empHrs = 0 ,  empWage = 0, totalEmpWage=0;

            for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++)
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
                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("Employee wage for day{0} is :{1}",day, empWage);
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total employee wage: {0}", totalEmpWage);
            Console.ReadLine();
        } 
    }   
}
