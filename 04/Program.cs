Console.WriteLine("Введите номер месяца");
int d = Convert.ToInt32(Console.ReadLine());
if (d > 0 && d < 13)
{
    if (d == 1 || d == 2 || d == 12) Console.Write("Зима, ");
    if (d >= 3 && d < 6) Console.Write("Весна, ");
    if (d >= 6 && d < 9) Console.Write("Лето, ");
    if (d >= 9 && d < 12) Console.Write("Осень, ");
}
else
{
    Console.WriteLine("Ошибка! Введите корректное значение от 1 до 12");
}
if (d == 1 || d == 6) Console.WriteLine("сессия");
if (d == 7 || d == 8) Console.WriteLine("каникулы");
if (d >= 9 && d <= 12) Console.WriteLine("1 семестр");
if (d > 1 && d < 6) Console.WriteLine("2 семестр");