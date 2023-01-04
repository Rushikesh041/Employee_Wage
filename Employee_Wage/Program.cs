namespace Employee_Wage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel Come to Employee Wage Computation");
            //Constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}