/*
+Which namespace is needed?
System? Threading?

+Which class and method are used to run a process?
Process, Process.Start()

+How can we modify properties of a process?
with class ProcessStartInfo and pass to Process.Start(params)

+How can we get a list of currently running processes?
Process.GetProcesses
*/

public class Program
{
    public static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
    }

    public static void HandleServer()
    {
        Server server = new Server();
        server.Communicate();
    }
    
    public static void HandleClient()
    {
        Client client = new Client();
        client.Communicate();
    }
}