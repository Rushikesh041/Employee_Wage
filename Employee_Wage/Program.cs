namespace Employee_Wage
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addcompanyEmpWage("JIO", 35, 25, 120);
            empWageBuilder.addcompanyEmpWage("VI", 40, 26, 140);

            empWageBuilder.computeEmpWage();
        }
    }
    
    
}