//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.



Console.WriteLine("Введите цело число ");
int input = int.Parse(Console.ReadLine()!);

int sumNum = 0;
Console.Write($"Сумма цифр числа {input} ");
while (input > 0)
{
    sumNum += input % 10;
    input = input / 10;
}

Console.Write($"равна: {sumNum}");
