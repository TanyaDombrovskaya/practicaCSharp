using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinoteatr
{
    class PipeClient
    {
        static void Main(string[] args)
        {
            using (var pipeClient = new NamedPipeClientStream(".", "ChatPipe", PipeDirection.InOut))
            {
                try
                {
                    pipeClient.Connect();
                    Console.WriteLine("Подключено к серверу.");

                    using (var reader = new StreamReader(pipeClient))
                    using (var writer = new StreamWriter(pipeClient) { AutoFlush = true })
                    {
                        while (true)
                        {
                            Console.Write("Введите сообщение: ");
                            string message = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(message)) break;

                            writer.WriteLine(message);
                            Console.WriteLine("Сообщение отправлено.");

                            string response = reader.ReadLine();
                            Console.WriteLine("Ответ от сервера: " + response);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }
            }
        }
    }
}
