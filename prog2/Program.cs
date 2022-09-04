//  Задайте массив. 
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
Console.WriteLine("Enter number. Search:");
int num = int.Parse(Console.ReadLine());
int[] array = new int [10];

for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(1, 11);
}
var str = string.Join(", ", array);
Console.WriteLine(str);

foreach (int item in array)
{
    if (num == item) Console.WriteLine($"Да! {num}");
    else Console.WriteLine("Нет числа");
}
