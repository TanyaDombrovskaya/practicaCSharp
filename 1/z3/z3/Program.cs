class Task3 {
    static void Main() {
        int number = 0;

        while (number < 1 || number > 20) {
            Console.Write("Введите целое число N (1 <= N <= 20): ");
            number = Convert.ToInt32(Console.ReadLine());
        }

        double sum = 0;

        for (int i = 1; i <= number; i++) {
            sum += 1.0 / i;
        }

        Console.WriteLine($"Сумма: {sum:F4}");
    }
}