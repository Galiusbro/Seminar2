//Задача 3: Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите любое число от 1 до 99999: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 > 0)
{
    number %= 1000;
    number /= 100;
    Console.WriteLine(number);
}
else Console.WriteLine("третьей цифры нет");