//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("Введите число");
var result = Convert.ToInt32(Console.ReadLine());
var number = result/10;
System.Console.WriteLine($"{number%10}");
