﻿// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5           78 -> третьей цифры нет          32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    int num = number % 10;
    Console.WriteLine(num);
}
