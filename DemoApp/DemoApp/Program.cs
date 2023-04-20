namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine(num3);

        }
    }
}