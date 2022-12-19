string loc;
Console.WriteLine("Введите первую букву Страны: б – Беларусь, Минск, р – Россия, Москва, л –Литва, Вильнюс");
string Country = Console.ReadLine()!;
switch (Country)
{
    case "б": loc = "Беларусь, Минск"; break;
    case "р": loc = "Россия, Москва"; break;
    case "л": loc = "Литва, Вильнюс"; break;
    default: loc = "Другая страна"; break;
}
Console.WriteLine(loc);