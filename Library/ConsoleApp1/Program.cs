using ClassLibrary1;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Enter the first Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What Operation would you like to do:");
            Console.WriteLine("1 - Addition \n2 - Subtraction\n3 - Multiplication\n4 - Division");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        int c = calc.Sum(a, b);
                        Console.WriteLine($"Addtion of {a} and {b} is {c}");
                        break;
                    }
                case 2:
                    {
                        int c = calc.Subtract(a, b);
                        Console.WriteLine($"Subtraction of {a} and {b} is {c}");
                        break;
                    }
                case 3:
                    {
                        int c = calc.Multiply(a, b);
                        Console.WriteLine($"Multiplication of {a} and {b} is {c}");
                        break;
                    }
                case 4:
                    {
                        int c = calc.Divide(a, b);
                        Console.WriteLine($"Division of {a} and {b} is {c}");
                        break;
                    }
            }
   
        Console.ReadKey();

        }
       
    }
}