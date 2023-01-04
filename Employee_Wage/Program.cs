namespace Employee_Wage
{
    public class Program
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, EMP_RATE_PER_HOUR = 20, NUM_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Wel Come to Employee Wage Computation");
            // Variables
            int empHrs = 0, empWage = 0, totalempwage = 0;
            Random random = new Random();
            //Computation
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
            empWage = empHrs * EMP_RATE_PER_HOUR;
            totalempwage = empWage * NUM_OF_WORKING_DAYS;
            Console.WriteLine("Emp Wage : " + empWage);
            Console.WriteLine("Total Emp Wage : " + totalempwage);
        }
    }
    
}