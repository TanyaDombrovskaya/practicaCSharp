using System.Runtime.InteropServices;

namespace PalindromNamespace
{
    class Palindrom
    {
        private int _number;

        public Palindrom(int number) {
            _number = number;
        }

        public bool IsPalindrom() {
            string stringNumber = _number.ToString();
            int length = stringNumber.Length;

            for (int i = 0; i < length / 2; i++) {
                if (stringNumber[i] != stringNumber[length - i - 1]) { 
                    return false;
                }
            }

            return true;
        }

        public void Result(bool answer) {
            if (answer)
            {
                Console.WriteLine("Число является палиндромом.");
            }
            else 
            { 
                Console.WriteLine("Число не является палиндромом.");
            }
        }
    }
}
