namespace PNS
{
    public class Printer
    {
        public void Print(string document)
        {
            Console.WriteLine($"Печать документа: {document}");
        }

        public void Cancel()
        {
            Console.WriteLine("Печать отменена.");
        }
    }

}
