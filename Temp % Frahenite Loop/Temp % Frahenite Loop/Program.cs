Console.WriteLine("Sr.no Temprature(Celcius)          Temprature(Farenheit)");
for (int i = 0; i < 10; i++)
{
    Console.Write(i);
    Console.Write("      " + i * 10);
    double F = (1.8 * (i * 10)) + 32;
    Console.WriteLine("                           " + F);
}