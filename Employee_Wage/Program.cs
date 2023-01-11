namespace Employee_Wage
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder JIO = new EmpWageBuilder("JIO", 35, 25, 120);
            EmpWageBuilder VI = new EmpWageBuilder("VI", 40, 26, 140);
            JIO.computeEmpWage();
            
            VI.computeEmpWage();
           
        }
    }
    
    
}