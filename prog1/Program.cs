// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные,
// и наоборот.

int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(-8, 9);
}
var str = string.Join(", ", array);
Console.WriteLine(str);

foreach (int item in array)
{
    int get = item * -1;
    Console.Write(get + ", ");
}