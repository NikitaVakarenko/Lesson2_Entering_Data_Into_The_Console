# C# Lesson 2: Entering Data Into The Console


This repository contains a basic C# console application that demonstrates how to read user input from the console and display it back to the user.

## Overview

The purpose of this project is to provide a simple, fundamental example of console I/O (Input/Output) operations in C#. The application prompts the user to enter a line of text, reads that input, and then echoes it back to the console.

This project is built using the .NET Framework 4.7.2.

## How to Run

### Prerequisites
*   [Visual Studio](https://visualstudio.microsoft.com/)
*   .NET Framework 4.7.2 or later

### Steps
1.  Clone the repository to your local machine:
    ```sh
    git clone https://github.com/NikitaVakarenko/Lesson2_Entering_Data_Into_The_Console.git
    ```
2.  Navigate to the cloned directory.
3.  Open the `Lesson_Entering_Data_Into_The_Console.sln` file in Visual Studio.
4.  Build the solution (Build > Build Solution or `Ctrl+Shift+B`).
5.  Run the project by pressing `F5` or clicking the "Start" button.

When the application runs, it will display the following prompt in the console:
```
Enter your data:
```
After you type your input and press `Enter`, the program will display your data back to you:
```
Enter your data:Hello, World!
Data:Hello, World!
```

## Code
The core logic is handled in the `Main` method of the `Program.cs` file. It uses `Console.Write()` to display a prompt, `Console.ReadLine()` to capture the user's input as a string, and `Console.WriteLine()` to display the captured data.

```csharp
// File: Lesson_Entering_Data_Into_The_Console/Program.cs

static void Main(string[] args)
{
    //Entering_Data_Into_The_Console
    Console.Write("Enter your data:");
    string data = Console.ReadLine();
    Console.WriteLine($"Data:{data}");
    Console.ReadKey();
}
