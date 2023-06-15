// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число");
var result = Convert.ToInt32(Console.ReadLine());
if(result > 999)

{
    result = result/10;
    System.Console.WriteLine($"{result%10}");
}  
else
{
    System.Console.WriteLine("не трехзначное");
    
} 






