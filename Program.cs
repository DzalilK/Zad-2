// Напешите программу,которая на вход принимает два числа и выдает, 
// какое число больше,а какое меньше.

Console.WriteLine("Enter fist number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine("Значит первое число являеться больше второго");
}
else
{
    Console.WriteLine("Значит второе число больше првого");
}
