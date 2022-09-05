//  Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

int[] array = new int[123];
for (int i = 0; i < 123; i++)
{
    array[i] = new Random().Next(1, 200);
}

var str = string.Join(", ", array);
Console.WriteLine(str);

int res = 0;
foreach (int item in array)
{
    if (item > 9 && item < 100)
    {
        res = res + 1; 
    }
}
Console.WriteLine($"Итоговое количество значений: {res}");