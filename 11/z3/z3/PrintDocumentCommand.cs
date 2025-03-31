namespace PNS
{
    public class PrintDocumentCommand : ICommand
    {
        private readonly Printer _printer;
        private readonly string _document;

        public PrintDocumentCommand(Printer printer, string document)
        {
            _printer = printer;
            _document = document;
        }

        public void Execute()
        {
            _printer.Print(_document);
        }
    }
}
