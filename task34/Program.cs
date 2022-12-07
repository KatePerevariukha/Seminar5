void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100,1000);
}

void ReleaseArray(int[] array)
{
    int countEventNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            countEventNumbers++;
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {countEventNumbers}");
}

Console.Write("Введите количество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);