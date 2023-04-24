String Response;
do
{
    Console.WriteLine("Enter the Temperature in Degree Celsius: ");
    int t = Convert.ToInt16(Console.ReadLine());



    double f = t * 1.8 + 32;
    Console.WriteLine("Temperature(Celsius): " + t + " Temperature(Fahrenheit): " + f);
    Console.WriteLine("Do You Wish to Continue(Y/N)?");
    Response = Console.ReadLine();
} while (Response == "Y");



