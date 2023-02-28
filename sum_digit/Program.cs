// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);

int GetSumma(int number)
{
int Summa = 0; 
while (number > 0)
{
Summa +=number%10; 
number /= 10; 
}
return Summa;
}

Console.WriteLine($"Сумма цифр в числе: {GetSumma(num)}");