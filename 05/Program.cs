Console.WriteLine("Введите ваш рост в сантиметрах");
int Height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваш вес в килограммах");
int Weight = Convert.ToInt32(Console.ReadLine());
double MeasurementError = Weight * 0.1;
double MinNormalWeight = (Height - 100) - MeasurementError;
double MaxNormalWeight = (Height - 100) + MeasurementError;
if (Weight < MinNormalWeight) Console.WriteLine("Нужно поправиться");
if (Weight >= MinNormalWeight && Weight <= MaxNormalWeight) Console.WriteLine("Норма");
if (Weight > MaxNormalWeight) Console.WriteLine("Нужно похудеть");