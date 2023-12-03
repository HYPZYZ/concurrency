using System.Diagnostics;
using System.IO.Pipes;

public class Server
{
    public void Communicate()
    {
        // start pipe / connect with client
        var server = new NamedPipeServerStream("namedPipe", PipeDirection.InOut);
        server.WaitForConnection();
        
        var reader = new StreamReader(server);

        while (true)
        {
            Console.WriteLine("READ\nEXIT");
            string action = Console.ReadLine();

            switch (action?.ToUpper())
            {
                case "READ":
                {
                    string path = reader.ReadLine();
                    
                    Console.WriteLine($"Given path: {path}");

                    ProcessStartInfo processStartInfo = new();
                    processStartInfo.FileName = path;

                    Process.Start(processStartInfo);
                    
                    break;
                }
                case "EXIT":
                {
                    Console.WriteLine("Exiting script");
                    return;
                }
            }
        }
    }
}