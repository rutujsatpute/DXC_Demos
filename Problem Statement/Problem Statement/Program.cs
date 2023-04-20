namespace Problem_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p = 23000.00;
            double r = 0.1275;
            Console.WriteLine("Enter the number of years");
            int t = Convert.ToInt32(Console.ReadLine());
            double i = p * r * t;
            Console.WriteLine(i);
           
        




        }
    }
}