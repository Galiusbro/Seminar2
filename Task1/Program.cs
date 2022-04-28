//Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

number /= 10;
number %= 10;
Console.WriteLine(number);