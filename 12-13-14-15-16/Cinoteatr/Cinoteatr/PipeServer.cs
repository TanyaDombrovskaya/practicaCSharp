using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinoteatr
{
    class PipeServer
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Сервер запущен. Ожидаем подключения клиента...");

            using (var pipeServer = new NamedPipeServerStream("ChatPipe", PipeDirection.InOut))
            {
                await pipeServer.WaitForConnectionAsync();
                Console.WriteLine("Клиент подключен.");

                using (var reader = new StreamReader(pipeServer))
                using (var writer = new StreamWriter(pipeServer) { AutoFlush = true })
                {
                    while (true)
                    {
                        string message = await reader.ReadLineAsync();
                        if (message == null) break;
                        Console.WriteLine("Сообщение от клиента: " + message);

                        string response = "Сервер получил сообщение: " + message;
                        await writer.WriteLineAsync(response);
                        Console.WriteLine("Ответ клиенту отправлен.");
                    }
                }
            }

            Console.WriteLine("Сервер завершил работу.");
        }
    }
}
