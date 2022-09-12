//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите цело число ");
int input = int.Parse(Console.ReadLine()!);


int sumCount(int a)
{
    int sumNum = 0;
    while (a > 0)
    {
        sumNum += a % 10;
        a = a / 10;
    }
    return sumNum;
}

void writeSum(int a, int b)
{
    Console.WriteLine($"Сумма цифр числа {a} равна: {b}");
}


int result = sumCount(input);
writeSum(input, result);