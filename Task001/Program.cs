// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] randomArray(int start, int end, int lenghtArray)
{
    int[] array = new int[lenghtArray];
    for (int i = 0; i < lenghtArray; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int[] array = randomArray(100, 999, 4);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine(count);