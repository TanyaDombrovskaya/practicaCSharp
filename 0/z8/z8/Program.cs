double x = 2.7;

double y = Math.Log(x + Math.Sqrt(Math.Pow(x, 2) + 9)) - (x + 1) / (Math.Atan(Math.Pow(x, 3)));

Console.WriteLine(Math.Round(y, 2));