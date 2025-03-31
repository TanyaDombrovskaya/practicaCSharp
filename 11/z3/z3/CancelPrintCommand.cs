﻿namespace PNS
{
    public class CancelPrintCommand : ICommand
    {
        private readonly Printer _printer;

        public CancelPrintCommand(Printer printer)
        {
            _printer = printer;
        }

        public void Execute()
        {
            _printer.Cancel();
        }
    }

}
