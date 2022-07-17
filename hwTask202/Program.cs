// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    string num = number.ToString();
    Console.WriteLine($"Третья цифра: {num[2]}");
}
else if (number < -99)
{
    string num = number.ToString();
    Console.WriteLine($"Третья цифра: {num[3]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); //32679
if (number > 99 || number < -99)
{
    while (number > 999 || number < -999) number /= 10;
Console.WriteLine(number %= 10);
}
else {Console.WriteLine("Такого нет");}