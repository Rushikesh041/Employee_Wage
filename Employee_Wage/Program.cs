namespace Employee_Wage
{
    public class Program
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2;

        public static int computeEmpWage(string company, int EMP_RATEPER_HOUR, int NUM_OF_WORKING_DAYS, int MAX_HOURS_IN_MONTH)
        {
            
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
                totalWorkingDays++;
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }

            int totalempwage = totalEmpHrs * EMP_RATEPER_HOUR;
            Console.WriteLine("Total Emp Wage of  "+ company + " is : " + totalempwage);
            return totalempwage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("JIO", 35, 25, 120);
            computeEmpWage("VI", 40, 26, 140);
        }
    }
    
    
}