// // Методы: воз-т значение и void
// // тип_метода ИмяМетода(параметр1, параметр2)
// // Параметры: два числа и знак арифм. операции

// int Calculate(int first, int second, char sign)
// {
//     if (sign == '+') // '' - только для char, буква "э" на англ. раскл
//     {
//         return first + second;
//     }
//     else if (sign == '-') // '' - только для char, буква "э" на англ. раскл
//     {
//         return first - second;
//     }
//     else if (sign == '*') // '' - только для char, буква "э" на англ. раскл
//     {
//         return first * second;
//     }
//     else // Другие "знаки" : все, кроме "+", "-", "*"
//     {
//         Console.WriteLine("Ошибка при вводе знака");
//         return 0;
//     }
// }

// // Используем метод - вызов
// // (int first, int second, char sign)
// Console.WriteLine(Calculate(2, 5, '+'));
// // first = 2, first = 5, char = '+'
// Console.WriteLine(Calculate(100, 35, '-'));
// // first = 100, first = 35, char = '-'
// Console.WriteLine(Calculate(100, 35, '*'));
// // first = 100, first = 35, char = '*'
// Console.WriteLine(Calculate(100, 35, '/'));
// // first = 100, first = 35, char = '/

// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10 
// 8 -> 36

// Console.Write("Введите число А: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// // Вызов метода
// Console.WriteLine($"Сумма чисел от 1 до {limit} = {GetSum(limit)}");
// // тип_метода ИмяМетода (параметр1, параметр2...параметрN)
// int GetSum (int A)
// {
//     int sum = 0;
//     // i = 1 - начало, 
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i; // sum = sum + i
//     }
//     return sum;
// }