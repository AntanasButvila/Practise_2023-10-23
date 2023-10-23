// Методы: воз-т значение и void
// тип_метода ИмяМетода(параметр1, параметр2)
// Параметры: два числа и знак арифм. операции

int Calculate(int first, int second, char sign)
{
    if (sign == '+') // '' - только для char, буква "э" на англ. раскл
    {
        return first + second;
    }
    else if (sign == '-') // '' - только для char, буква "э" на англ. раскл
    {
        return first - second;
    }
    else if (sign == '*') // '' - только для char, буква "э" на англ. раскл
    {
        return first * second;
    }
    else // Другие "знаки" : все, кроме "+", "-", "*"
    {
        Console.WriteLine("Ошибка при вводе знака");
        return 0;
    }
}

// Используем метод - вызов
// (int first, int second, char sign)
Console.WriteLine(Calculate(2, 5, '+'));
// first = 2, first = 5, char = '+'
Console.WriteLine(Calculate(100, 35, '-'));
// first = 100, first = 35, char = '-'
Console.WriteLine(Calculate(100, 35, '*'));
// first = 100, first = 35, char = '*'
Console.WriteLine(Calculate(100, 35, '/'));
// first = 100, first = 35, char = '/