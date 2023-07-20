// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetArray(int size, double maximum, double minimum)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * (maximum - minimum) + minimum;
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}

double MaxMinResult(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];

    }
    double result = max - min;
    return result;
}
double[] ArrayResult = GetArray(5, 0.1, 99.9);
double result = MaxMinResult(ArrayResult);
Console.WriteLine($"В массиве [{String.Join(", ", ArrayResult)}] разница между максимальным и минимальным элементов массива = {result:f2}");
