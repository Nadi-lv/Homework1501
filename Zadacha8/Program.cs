Console.WriteLine("Четные числа от 1 до n");

Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0) 
{
    Console.WriteLine( " введите другое число");
}

int i = 2;

 while (i < number +1)
{    
    if (( i % 2 ) == 0)
    Console.Write ( i + ", ");
    i = i + 2;
}