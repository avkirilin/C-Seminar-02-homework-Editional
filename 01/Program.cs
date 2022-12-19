Console.WriteLine("Введите любое целое число");
int d = Convert.ToInt32(Console.ReadLine());
int n = new Random().Next(20, 100);
string a;
Console.WriteLine($"Наше случайное число: {n}");
Console.WriteLine(a = (n % d == 0) ? $"Случайное число делится на {d}" : $"Случайное число не делится на {d}");