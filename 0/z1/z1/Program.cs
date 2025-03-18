Console.WriteLine("Введите величину временного интервала(в минутах) и нажмите <Enter>");
int timeMinute = Convert.ToInt32(Console.ReadLine());

int ours = timeMinute / 60;
int minute = timeMinute % 60;

Console.WriteLine($"{timeMinute} - минут это {ours} ч. {minute} мин.");