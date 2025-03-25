namespace Validator
{
    public class InvalidEmailFormatException : Exception
    {
        public InvalidEmailFormatException(string message)
            : base(message)
        {
        }
    }

    public class EmailValidator
    {
        public void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                throw new InvalidEmailFormatException($"Неверный формат электронной почты: {email}");
            }
            else
            {
                Console.WriteLine($"Электронная почта {email} прошла проверку.");
            }
        }
    }
}
