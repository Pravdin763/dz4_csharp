 // Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

 int i = 0;
int[] array = new int[8];

while (i < array.Length)
{
    Console.WriteLine($"Введите цело число: {i + 1} из 8");
    array[i] = int.Parse(Console.ReadLine());
    i += 1;
}

Console.WriteLine(string.Join(", ", array));