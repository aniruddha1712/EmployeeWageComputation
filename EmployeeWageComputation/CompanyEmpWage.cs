using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHr;
        public int numOfWorkingDays;
        public int maxWorkingHrs;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void setTotalWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total emp wage for company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
