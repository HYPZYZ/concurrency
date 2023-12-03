using System;
using System.Diagnostics;

/// This example shows how to define a process and start it.
/// Check here: https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process?view=netcore-3.1


namespace Exercise
{
    public class ProcessCreation
    {
        public virtual void createProcess()
        {
            // Todo: Create an object from ProcessStartInfo
            // Implement your code here ...
            ProcessStartInfo processStartInfo = new ProcessStartInfo();


            // Todo: Provide the path and the name of your executable file
            // Implement your code here
            // processStartInfo.FileName = "\"C:\\Battlestate Games\\BsgLauncher\\BsgLauncher.exe\"";
            processStartInfo.FileName = "C:\\Users\\rik\\Documents\\RiderProjects\\concurrency\\Processes\\bin\\Debug\\net6.0\\Processes.exe";


            // processStartInfo.CreateNoWindow = false; // This means start the process in a new window
            // processStartInfo.UseShellExecute = false;

            try
            {
                // Todo: Start your process and then wait for its exit
                // Implement your code here
                Process.Start(processStartInfo);

            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }

        }
    }
}
