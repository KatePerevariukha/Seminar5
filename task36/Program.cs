// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,100);
}

void ReleaseArray(int[] array)
{
    int sumEventIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sumEventIndex = sumEventIndex + array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumEventIndex}");
}

Console.Write("Введите количество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);