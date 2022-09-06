// Задайте массив заполненный случайными положительными трёхзначными числами. 

// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// void CreateAndPrintOldArray()
// {
int[] array = new int[10];

int i = 0;
for (i = 0; i < 10; i++)
{
    array[i] = new Random().Next(100, 1000);
}

var str = string.Join(", ", array);
Console.WriteLine(str);
// }

// void Result()
// {
int res = 0;
foreach (int item in array)
{
   if (item % 2 == 0) res = res + 1;
}
// while (array[i] % 2 == 0)
// {
//     res = res + 1;
// }

// for (i = 0; i < 10; i++)
// {
//     array[i] % 2 == 0;
//     i = i+1;
// }

Console.WriteLine($"Количество чётных чисел: {res}");
// }

// CreateAndPrintOldArray(str);
// Result(res);