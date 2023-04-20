Console.WriteLine("Enter the 2 Numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enetr the Repository");
Char ch = Convert.ToChar(Console.ReadLine());
switch (ch)
{
    case '+':
        {
            int sum = num1 + num2;
            Console.WriteLine("Result is " + sum);
            break;
        }
    case '_':
        { 
            int sub = num1 - num2;
            Console.WriteLine("Result is " + sub); 
            break;
        }
    case '*':
        {
            int mul = num1 * num2;
            Console.WriteLine("Result is " + mul);
            break;
        }
    case '/':
        {
            int div = num1 / num2;
            Console.WriteLine("Result is " + div);
            break;
        }
        default :
        {
            Console.WriteLine("Wrong Choice");
            break;
        }
}
    
