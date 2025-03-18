Console.WriteLine("Введите трехзначное число: ");
int originalNumber = Convert.ToInt32(Console.ReadLine());

int num1 = originalNumber / 100;
int num2 = (originalNumber % 100) / 10;
int num3 = originalNumber % 10;

int newNum1 = num1 * 100 + num2 * 10 + num3;
int newNum2 = num1 * 100 + num3 * 10 + num2;
int newNum3 = num2 * 100 + num1 * 10 + num3;
int newNum4 = num2 * 100 + num3 * 10 + num1;
int newNum5 = num3 * 100 + num1 * 10 + num2;
int newNum6 = num3 * 100 + num2 * 10 + num1;

Console.WriteLine("Шесть возможных чисел:");
Console.WriteLine(newNum1);
Console.WriteLine(newNum2);
Console.WriteLine(newNum3);
Console.WriteLine(newNum4);
Console.WriteLine(newNum5);
Console.WriteLine(newNum6);

