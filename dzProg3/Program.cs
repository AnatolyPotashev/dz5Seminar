// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double [10];
for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(1, 100);
}
var str = string.Join(", ", array);
Console.WriteLine(str);

// Поиск минимального и максимального
double min = array.Min();
double max = array.Max();
double res = max - min;
Console.WriteLine($"Минимальное: {min}, Максимальное: {max}, Разница: {res}");
