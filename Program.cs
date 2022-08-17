// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// способ 1
// Console.Write("Введите число A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int result = numA;

// for (int i = 1; i < numB; i++)
// {
//     result = result *numA;
// }  
// Console.WriteLine($"число А в степени В равно: {result}");


// способ 2
// Console.Write("Введите число A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// double result = Math.Pow(numA, numB);
// Console.WriteLine($"число А в степени В равно: {result}");

// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (number > 0)
// {
//     int result = number % 10;
//     number /= 10;
//     sum = sum + result;
// }
// Console.WriteLine($"Сумма цифр чисела равна {sum}");


// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите 8 чисел через запятую: ");
int[] array = {};
void PrintArray()
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
         Console.Write(array[i] + " ");
    }
}
Console.WriteLine($"Массив: [ {String.Join(";"), PrintArray()} ]");
