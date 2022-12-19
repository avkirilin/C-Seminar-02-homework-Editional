string mes;
Console.WriteLine("Введите первую букву школьной дисциплины: ф - физика, м - математика, и - история, г - география, б - биология");
string Lesson = Console.ReadLine();
switch (Lesson)
{
    case "ф": mes = "Физика"; break;
    case "м": mes = "Математика"; break;
    case "и": mes = "История"; break;
    case "г": mes = "География"; break;
    case "б": mes = "Биология"; break;
    default: mes = "Другой предмет"; break;
}
Console.WriteLine(mes);