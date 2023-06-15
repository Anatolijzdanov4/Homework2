// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите число");
var number = Convert.ToInt32(Console.ReadLine());
if(number<6)
{
    System.Console.WriteLine("Будний день");
}
else if(number == 6)
{
    System.Console.WriteLine("Выходной день");
}
else if(number == 7)
{
    System.Console.WriteLine("Выходной день");
}
else if(number > 7)
{
    System.Console.WriteLine("Не являеться днем недели");
}