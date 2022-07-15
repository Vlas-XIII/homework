// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int x1 = 6;
int x2 = 7;
Console.Write("Введите цифру обозначающую день недели от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
string[] dayWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"};
if (dayNumber >= 1 && dayNumber <= 7)
{
    Console.WriteLine(dayWeek[dayNumber - 1]);
    if ( dayNumber == x1 || dayNumber == x2)
    {
        Console.WriteLine("Отдыхай!!!");
    }
    else
    {
        Console.WriteLine("Работать!");
    }
}
else {Console.WriteLine("Подумай ещё");}

// Вариант решения 2
/*
Console.Write("Введите цифру от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
int x1 = 5;
int x2 = 6;
if (dayNumber >= 1 && dayNumber <= 7) //[1;7] True && True -> True  && - двойное условие
{
    if (dayNumber == 1)
    {
        Console.WriteLine("Понедельникн");
    }
    if (dayNumber == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (dayNumber == 3)
    {
        Console.WriteLine("Среда");
    }
    if (dayNumber == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (dayNumber == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (dayNumber == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (dayNumber == 7)
    {
        Console.WriteLine("Воскресенье");
    }
    if ( dayNumber == x1 || dayNumber == x2 )
    {
        Console.WriteLine("Отдыхай!!!");
    }
    else
    {
        Console.WriteLine("Работай!");
    }
}
else
{
    Console.WriteLine("Error 404, day not found");
}
*/