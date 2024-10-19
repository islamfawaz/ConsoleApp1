namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var user01 = new User(1, "Islam", "Manager");

            var user02 = new User(2, "Ahmed", "Employee");

            var user03 = new User(3, "Fawaz", "TL");



            Console.WriteLine(user01.ToString());
            Console.WriteLine(user02.ToString());
            Console.WriteLine(user03.ToString());


        }


    }
}
