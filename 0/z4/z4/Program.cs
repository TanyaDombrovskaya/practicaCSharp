Console.WriteLine("Введите первое число до двух знаков после запятой: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число до двух знаков после запятой: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double sum = num1 + num2;

Console.WriteLine($"{num1} + {num2} = {sum}");