// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if( number > 99 && number < 1000)
{
    int x1 = number % 100;
    x1 /= 10;
    Console.WriteLine("Вторая цифра: " + x1);
}
else
{
    Console.WriteLine("Не лги себе");
}

// Второй вариант решения
/*
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number > 99 && number < 1000)
{
    string num = number.ToString();
    Console.WriteLine($"Вторая цифра: {num[1]}");
}
else
{
    Console.WriteLine("Не лги себе");
}
*/