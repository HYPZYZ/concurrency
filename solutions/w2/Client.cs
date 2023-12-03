using System.IO.Pipes;

public class Client
{
    public void Communicate()
    {
        var client = new NamedPipeClientStream("namedPipe");
        client.Connect();

        var writer = new StreamWriter(client);
        
        while (true)
        {
            Console.WriteLine("SEND\nEXIT");
            string action = Console.ReadLine();

            switch (action?.ToUpper())
            {
                case "SEND":
                {
                    Console.WriteLine("Path to execute");
                    string path = Console.ReadLine();
                    
                    writer.WriteLine(path);
                    writer.Flush();
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