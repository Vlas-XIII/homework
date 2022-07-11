//Домашняя работа Задача 2: Напишите программу, 
//которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
int min = numberB;
if (max == min)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (numberB > max)
    {
        max = numberB;
        min = numberA;
        Console.WriteLine(max + " больше " + min);
    }
    else
    {
        Console.WriteLine(max + " больше " + min);
    }
}