
Console.WriteLine("Enter Student ID");
int sdi = Convert .ToInt32(Console.ReadLine());
Console.WriteLine("Enter Student Name");
String sdn = Convert .ToString(Console.ReadLine());
Console.WriteLine("Enter the Age of Student");
int age = Convert .ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Marks for Subject 1");
int mrk1 = Convert .ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Marks for Subject 2");
int mrk2 = Convert .ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Marks for Subject 3");
int mrk3 = Convert .ToInt32(Console.ReadLine());

int sum = mrk1 + mrk2 + mrk3;
Console.WriteLine("Total Score is ="+sum);

int avg = sum/3;
Console.WriteLine("Your Total Average is =" + avg);

if (avg >= 90 && avg <= 100)
{
    Console.WriteLine("Your Grade is A");
}
if (avg >= 80 && avg <= 89)
{
    Console.WriteLine("Your Grade is B");
}
if (avg >= 60 && avg <= 79)
{
    Console.WriteLine("Your Grade is C");
}
if (avg >=50 && avg <=69)
{
    Console.WriteLine("Your Grade is D");
}
if (avg < 50)
{
    Console.WriteLine("Your Result for Exam is Fail");
}
else
{
    Console.WriteLine("Your Result for Exam is Pass");
}