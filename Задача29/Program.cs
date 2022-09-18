// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int [] array = new int [8];

void Rand(int [] arr)
{
int length = arr.Length;
int index = 0;
Console.Write("[");
while (index < length-1)
//for (int i = 0; i < 8; i++)
{
arr[index] = new Random().Next(0,1000);
Console.Write($"{arr[index]},");
index++;
}
Console.Write($"{arr[index]}");

Console.Write("]");
}
Rand(array);
