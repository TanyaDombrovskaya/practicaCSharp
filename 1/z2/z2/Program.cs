using PalindromNamespace;

class Task2 {
    static void Main() {
        int number = 0;

        while (number.ToString().Length != 4) {
            Console.Write("Введите четырехзначное число: ");
            number = Convert.ToInt32(Console.ReadLine());
        }

        Palindrom palindrom = new(number);

        bool answer = palindrom.IsPalindrom();

        palindrom.Result(answer);
    }
}