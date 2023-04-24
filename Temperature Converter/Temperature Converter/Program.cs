namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (int i = 0; i <= 100; i = i+10)
           
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter the Temperature");
            int t = Convert.ToInt32(Console.ReadLine());

           double j = ( t * 1.8) + 32;
            Console.WriteLine(j);
            for (j=32; j <= 100; j++) ;

        }
    }
}