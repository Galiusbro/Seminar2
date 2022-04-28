//Задача 4: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

Console.Write("Введите любое число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7) Console.WriteLine("yes");
else Console.WriteLine("no");