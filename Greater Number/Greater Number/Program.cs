int num1, num2;
Console.WriteLine("Enter the First Number");
num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the Second Number");
num2 = Convert.ToInt16(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("First Number is Greater");
}
else if (num2 > num1)
{
    Console.WriteLine("Second Number is Greater");
}

else
{
    Console.WriteLine("Both Number are Equal");
}