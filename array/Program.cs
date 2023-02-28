// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] a = new int[8];
Random rnd = new Random();
for(int i=0;i<8;i++)
a[i]=rnd.Next(0,10);
Console.WriteLine("Вывод элементов массива");
for(int i=0;i<8;i++)
Console.WriteLine($"a[{i}]={a[i]}");

// ВТОРОЙ ВАРИАНТ
// int[] a = new int[8];
// Console.WriteLine("Ввод элементов массива");
// for(int i=0;i<8;i++)
// {
// Console.Write($"Введите a[{i}]=");
// a[i]=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(a[i]);
// }
// Console.WriteLine("Вывод элементов массива");
// for(int i=0;i<8;i++)
// {
// Console.WriteLine($"a[{i}]={a[i]}");
// }






