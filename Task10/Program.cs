// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result1 = (number - (number/100*100));
int result2 = (result1/10);
System.Console.WriteLine($"Вторая цифра введеного числа {result2}");