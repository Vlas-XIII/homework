// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); //32679
int oldNum = number;
int newNum = 0;
if (number > 9999 && number < 100000)
{
    while (number > 0)
    {
        int x = number % 10;
        newNum = newNum * 10 + x;
        number /= 10;
    }
    if (newNum == oldNum) {Console.WriteLine("Число является палиндромом");}
    else {Console.WriteLine("Не является палиндромом");}
}
else {Console.WriteLine("Нужно пятизначное!");}
