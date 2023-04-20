//Decision Making Constructs in C#
//1. If..Else
//2. Switch..Case
//comparision Operator - ==,<,>,<=,>=,!=
int num;
Console.WriteLine("Enter Any Number");
num = Convert.ToInt16(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Number is Even");
}
else
{
    Console.WriteLine("Number is Odd");
}