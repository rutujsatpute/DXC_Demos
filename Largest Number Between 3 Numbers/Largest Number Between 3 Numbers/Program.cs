
using System.ComponentModel.Design;

Console.WriteLine("Enter the 3 Numbers");
int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());
int num3 = Convert.ToInt16(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("First Number is Greater");

}
else if (num2 > num3)
{
    Console.WriteLine("Second Number is Greater");

}
else
{
    Console.WriteLine("Third Number is Greater");

}

