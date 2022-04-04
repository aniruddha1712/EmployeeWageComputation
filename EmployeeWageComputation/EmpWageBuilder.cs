using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmpWageBuilder:IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private List<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyEmpWageDict;
        public EmpWageBuilder()
        {
            this.companyEmpWageList = new List<CompanyEmpWage>();
            this.companyEmpWageDict = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHr, numOfWorkingDays, maxWorkingHrs);
            this.companyEmpWageList.Add(companyEmpWage);
            this.companyEmpWageDict.Add(company, companyEmpWage);
        }
       
        public void computeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());

            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalWorkingHrs = 0, totalWorkingDays = 1;

            while (totalWorkingHrs<=companyEmpWage.maxWorkingHrs && totalWorkingDays<companyEmpWage.numOfWorkingDays)

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
                if (totalWorkingHrs >companyEmpWage.maxWorkingHrs)
                {
                    totalWorkingHrs -= empHrs;
                    break;
                }
                // Console.WriteLine("day: " + totalWorkingDays + " working hrs: " + empHrs);
                totalWorkingDays++;
            }
            return totalWorkingHrs * companyEmpWage.empRatePerHr;
        }
        public int getTotalWage(string company)
        {
            return this.companyEmpWageDict[company].totalEmpWage;
        }
    }
}
