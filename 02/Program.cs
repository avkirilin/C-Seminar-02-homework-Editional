int a = new Random().Next(10, 31);
Console.WriteLine($"Наше первое случайное число: {a}");
int b = new Random().Next(10, 31);
Console.WriteLine($"Наше второе случайное число: {b}");
if (a == b)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (a > b)
    {
        Console.WriteLine($"Первое число больше второго на: {a - b}");
    }
    else
    {
        Console.WriteLine($"Сумма обоих чисел равна: {a + b}");
    }
}