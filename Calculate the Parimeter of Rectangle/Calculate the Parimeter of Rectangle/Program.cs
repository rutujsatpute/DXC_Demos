using System.Diagnostics.CodeAnalysis;

namespace Calculate_the_Parimeter_of_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of Rectangle");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of Rectangle");
            int b = Convert.ToInt32(Console.ReadLine());
            
            int p = 2*(a+b);
            Console.WriteLine(p);

            Console.WriteLine("Enter the Length of Rectangle");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of Rectangle");
            double d = Convert.ToDouble(Console.ReadLine());

            double q = 2 * (c + d);
            Console.WriteLine(q);

            


        }
    }
}