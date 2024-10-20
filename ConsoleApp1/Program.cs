namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Manager manager = new Manager();
            decimal salary=manager.CalculateSalary();
            Console.WriteLine($"The total salary of all employees is: {salary}");
        }


    }
}
