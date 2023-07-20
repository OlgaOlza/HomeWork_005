// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] randomArray(int start, int end, int lenghtArray)
{
    int[] array = new int[lenghtArray];
    for (int i = 0; i < lenghtArray; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int[] array = randomArray(1, 99, 10);
int sum = 0;

for (int i = 0; i < array.Length; i+=2)
    sum = sum + array[i];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");


