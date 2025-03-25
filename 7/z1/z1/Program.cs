using Validator;

class Task1
{
    static void Main()
    {
        EmailValidator validator = new EmailValidator();

        Console.Write("Введите потчу: ");
        string email = Console.ReadLine();

        try
        {
            validator.ValidateEmail(email);
        }
        catch (InvalidEmailFormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}