//Display a simple message to the user
Console.WriteLine("*********** My First C# App *********");
Console.WriteLine("Hello World Again");
Console.WriteLine();

ShowEnvironmentDetails();

static void ShowEnvironmentDetails()
{
    foreach(string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive : {0}", drive);
    }

    Console.WriteLine("Machine Name : {0}", Environment.MachineName);
    Console.WriteLine($"Processor Count : {Environment.ProcessorCount}");
    Console.WriteLine($"Version : {Environment.Version}");
}
