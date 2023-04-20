// logical operator - &&, ||, !
// Age >= 18
// Qualification >= 10

Console.WriteLine("Enter your Age");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Qualification");
int qual = Convert.ToInt32(Console.ReadLine());
if (age >= 18 && qual >=10)
{
    Console.WriteLine("You are eligible");
}
else
{
    Console.WriteLine("You are not Eligible");
}
