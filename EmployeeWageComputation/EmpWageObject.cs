using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageObject
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHr;
        private int numOfWorkingDays;
        private int maxWorkingHrs;
        private int totalEmpWage;

        public EmpWageObject(string company, int empRatePerHr, int numOfWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }

        public void ComputeEmpWage()
        {
            int empHrs = 0, totalWorkingHrs = 0, totalWorkingDays = 1;

            while (totalWorkingDays <= this.numOfWorkingDays && totalWorkingHrs <= this.maxWorkingHrs)

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
               // Console.WriteLine("day: " + totalWorkingDays + " working hrs: " + empHrs);
                totalWorkingDays++;
            }
            totalEmpWage = totalWorkingHrs * this.empRatePerHr;
            Console.WriteLine("{0} Employee had worked for {1} hrs in {2} days and earned {3} rs",company, totalWorkingHrs, totalWorkingDays - 1, totalEmpWage);
        }
        public string toString()
        {
            return "Total emp wage for company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
