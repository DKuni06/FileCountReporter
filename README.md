
# FileCountReporter

A small .NET console application that counts the files and immediate subdirectories in a directory.

## Features

- Validates the directory path entered by the user.
- Counts files directly inside the selected directory.
- Counts immediate subdirectories.
- Displays separate file, folder, and combined totals.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Windows, or another operating system with a valid directory path

## Run the application

From the repository root, run:

```bash
dotnet run --project FileCountReporter/FileCountReporter.csproj
```

When prompted, enter the path to a directory. The application will continue prompting until a valid directory is provided.

## Example

```text
Files in directory: 12
Folders in directory: 3
Total count: 15
```
<img width="1102" height="225" alt="Screenshot 2026-10-28 144553" src="https://github.com/user-attachments/assets/29864461-48b4-4959-959f-6f1416ba412e" />
## Counting behavior

The application counts only files and folders directly within the selected directory. It does not recursively count the contents of nested folders.
