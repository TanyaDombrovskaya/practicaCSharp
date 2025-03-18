Console.WriteLine("Введите время(ч): ");
double t = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите ускорение(км/ч): ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите начальную скорость(км/ч): ");
double v0 = Convert.ToDouble(Console.ReadLine());

double v = v0 + a * t;

double s = (Math.Pow(v, 2) - Math.Pow(v0, 2)) / (a * 2);

Console.WriteLine($"Пройденное расстояние(км): {s}");
Console.WriteLine($"Скорость объекта(км/ч): {v}");