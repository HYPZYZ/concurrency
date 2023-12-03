using System;
using System.IO;
using System.IO.Pipes;
using System.Linq;

namespace Exercise
{
    public class IPCNamedClient
    {
        public virtual void ipcClientCommunicate()
        {
            Console.WriteLine("Pipe Client is being executed ...");
            Console.WriteLine("[Client] waiting to receive a message");

            var server = new NamedPipeServerStream("PipesOfConcurrency", PipeDirection.InOut);
            server.WaitForConnection();

            StreamReader reader = new StreamReader(server);
            StreamWriter writer = new StreamWriter(server);

            while (true)
            {
                String msg = reader.ReadLine();
                if (String.IsNullOrEmpty(msg)) // Finish if nothing is entered
                    break;
                else
                {
                    Console.WriteLine(msg); // Print the message received

                    string reversed = string.Join("", msg.Reverse());
                    Console.WriteLine(reversed); // Print the reverse of the received message
                    
                    writer.WriteLine(reversed);
                    writer.Flush();
                }
            }
        }
    }
}