Console.WriteLine("Hello, please enter a windows file explorer directory link!");
string filePath = Console.ReadLine();
// checks if path exists
while (!Directory.Exists(filePath))
{
    Console.WriteLine("Incorrect file path. Please try again.");
    filePath = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(filePath))
    {
        Console.WriteLine("Path cannot be empty. Try again.\n");
        continue;
    }
    else
    {
        Console.WriteLine("That directory does not exist. Try again.\n");
    }
}

