// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

int i = 0;
int[] array = new int[8];


int[] filling(int a, int[] arr)
{
    while (a < arr.Length)
    {
        Console.WriteLine($"Введите цело число: {a + 1} из 8");
        arr[a] = int.Parse(Console.ReadLine()!);
        a += 1;
    }
    return arr;
}

void writeArray(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
}


int[] result = filling(i, array);
writeArray(result);