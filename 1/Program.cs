//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Введите число А ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B ");
int numB = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{numA} в стеени {numB} равно: {Math.Pow(numA, numB)}");
