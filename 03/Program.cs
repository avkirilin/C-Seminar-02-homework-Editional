int c = new Random().Next(-10, 11);
Console.WriteLine($"Наше первое случайное число: {c}");
int d = new Random().Next(-10, 11);
Console.WriteLine($"Наше второе случайное число: {d}");
if (c % 2 == 0 && d % 2 == 0)
{
    Console.WriteLine($"Частное четных чисел {c} и {d}: {c / d}");
}
else
{
    if (c % 2 != 0 && d % 2 != 0)
    {
        Console.WriteLine($"Сумма нечетных чисел {c} и {d}: {c + d}");
    }
    else
    {
        Console.WriteLine($"Произведение чисел {c} и {d}: {c * d}");
    }
}