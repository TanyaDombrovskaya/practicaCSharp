Console.Write("Введите число m: ");
double m = Convert.ToDouble(Console.ReadLine());

double z1 = (Math.Sqrt(Math.Pow(3 * m +2, 2) - 24 * m)) / (3 * Math.Sqrt(m) - 2 / Math.Sqrt(m));
double z2 = - Math.Sqrt(m);

Console.WriteLine(Math.Round(z1, 2));
Console.WriteLine(Math.Round(z2, 2));
