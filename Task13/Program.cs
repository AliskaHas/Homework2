﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите положительное число: ");
int x = Convert.ToInt32(Console.ReadLine());
if(x<100)
    {
        System.Console.WriteLine("Нет третьей цифры в введеном числе");
    }
else
{
    while(x>999)
      {
          x = x/10;
      }
     System.Console.WriteLine($"Третья цифра в введеном числе {x%10}");
}