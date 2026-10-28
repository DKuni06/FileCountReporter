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
    else if (!Directory.Exists(filePath))
    {
        Console.WriteLine("That directory does not exist. Try again.\n");
    }
}
string[] files = Directory.GetFiles(filePath);
string[] folders = Directory.GetDirectories(filePath);
int fileCount = files.Length;
int folderCount = folders.Length;

Console.WriteLine("Files in directory: " + fileCount);
Console.WriteLine("Folders in directory: " + folderCount);
Console.WriteLine("Total count: " + (fileCount + folderCount));


