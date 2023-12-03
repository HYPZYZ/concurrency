using System;
using System.IO;
using System.IO.Pipes;

namespace Exercise
{
    public class IPCNamedServer
    {
        public virtual void ipcServerCommunicate()
        {
            Console.WriteLine("Pipe Server is being executed ...");
            Console.WriteLine("[Server] Enter a message to be reversed by the client (press ENTER to exit)");

            //Client
            var client = new NamedPipeClientStream(".","PipesOfConcurrency", PipeDirection.InOut);
            client.Connect();

            StreamWriter writer = new StreamWriter(client);
            StreamReader reader = new StreamReader(client);

            while (true)
            {
                String input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    var msg = reader.ReadLine();
                    Console.WriteLine(msg);
                    break;
                }
                else
                {
                    writer.WriteLine(input);
                    writer.Flush();
                }
            }
        }
    }
}