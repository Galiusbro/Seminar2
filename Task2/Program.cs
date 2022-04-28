//Задача 2: Напишите программу, которая выводит
//случайное трёхзначное число и удаляет вторую цифру
//этого числа.

int random = new Random().Next(100, 1000);
Console.WriteLine(random);

string numberToSting = $"{random / 100}";
numberToSting = numberToSting + $"{random % 10}";

Console.WriteLine(numberToSting);