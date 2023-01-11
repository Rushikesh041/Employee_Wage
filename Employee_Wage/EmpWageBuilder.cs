using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    public class EmpWageBuilder
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2;

        public int numOfCompany = 0;
        public CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilder()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addcompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                // companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                computeEmpWage(this.companyEmpWageArray[i]);
              //  Console.WriteLine(this.companyEmpWageArray[i].toString());

            }
        }

        public void computeEmpWage(CompanyEmpWage companyEmpWage)
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            Console.WriteLine("Total Emp Wage of " + companyEmpWage.company + " is " + totalEmpHrs * companyEmpWage.empRatePerHour); 
        }
    }
}
