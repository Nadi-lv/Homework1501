Console.WriteLine("Определение большего и меньшего числа");

Console.WriteLine ("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max)
{
    max = number2;
    Console.WriteLine("максимальное число " + max);
    Console.WriteLine("минимальное число " + number1);
}
else if (number2 == max)
{
     Console.WriteLine("числа равны");
}
else 
{
    Console.WriteLine("максимальное число " + max);
    Console.WriteLine("минимальное число " + number2);
}