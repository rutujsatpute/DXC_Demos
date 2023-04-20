using System.ComponentModel.Design;

Console.WriteLine("Enter Any Alphabet");

String Alp = Convert.ToString(Console.ReadLine());

if (Alp == "A" || Alp == "E" || Alp == "I" || Alp == "O" || Alp == "U")
{
    Console.WriteLine("Character is Vowel");
}
else
{
    Console.WriteLine("Character is Constant");
}



