using PNS;

class Task3
{
    static void Main()
    {
        Printer printer = new Printer();

        ICommand printCommand1 = new PrintDocumentCommand(printer, "Документ 1");
        ICommand printCommand2 = new PrintDocumentCommand(printer, "Документ 2");
        ICommand cancelCommand = new CancelPrintCommand(printer);

        PrintManager printManager = new PrintManager();

        printManager.AddCommand(printCommand1);
        printManager.AddCommand(printCommand2);
        printManager.AddCommand(cancelCommand);

        printManager.ExecuteCommands();
    }
}
