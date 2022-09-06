// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];
for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(1, 100);
}
var str = string.Join(", ", array);
Console.WriteLine(str);

int res = 0;
foreach (int item in array)
{
    if (item % 2 == 1) res = item + res;
}

Console.WriteLine(res);