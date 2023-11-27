

using System.Runtime.InteropServices;


namespace RideThatTrack.RaceThatTrack;

// public class Program
// {
//     [DllImport("kernel32.dll", SetLastError = true)]
//     static extern bool AllocConsole();
//
//     [DllImport("kernel32.dll", SetLastError = true)]
//     static extern bool FreeConsole();
//
//     [DllImport("kernel32.dll", SetLastError = true)]
//     static extern IntPtr GetConsoleWindow();
//
//     [DllImport("user32.dll")]
//     static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
//
//     const int SwShow = 5;
//     static void Main()
//     {
//         //Able to create a car (There should be different types of cars)
//         
//         //We should choose the track the moment we create the car
//         
//         //The car.Drive() method should be implemented here (For each time we drive the car we should check if the car )
//         
//         //The method that checks if the car can finish the race should be here
//         //Interface intrface = new Interface();
//         //intrface.ProgramInterface();
//         // AllocConsole creates a new console window
//         AllocConsole();
//
//         // Get the handle of the new console window
//         IntPtr hwnd = GetConsoleWindow();
//
//         // Show the console window
//         ShowWindow(hwnd, SwShow);
//
//         // Save the original standard output stream
//         TextWriter originalOutput = Console.Out;
//
//         try
//         {
//             // Redirect the standard output to the new console
//             Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
//
//             // Print to the original console
//             Console.WriteLine("Hello from the original console window!");
//
//             // Print to the new console
//             Console.WriteLine("Hello from the new console window!");
//
//             // Wait for user input
//             Console.ReadLine();
//         }
//         finally
//         {
//             // Restore the original standard output stream
//             Console.SetOut(originalOutput);
//
//             // Free the console when you're done
//             FreeConsole();
//         }
//         
//
//     }
//
//     /*public Program()
//     {
//         [DllImport("kernel32.dll", SetLastError = true)]
//         static extern bool AllocConsole();
//
//         [DllImport("kernel32.dll", SetLastError = true)]
//         static extern bool FreeConsole();
//
//         [DllImport("kernel32.dll", SetLastError = true)]
//         static extern IntPtr GetConsoleWindow();
//
//         [DllImport("user32.dll")]
//         static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
//
//         const int SW_SHOW = 5;
//         
//         
//         
//         
//     }*/
// }
//

using System;
using System.Runtime.InteropServices;
using System.IO;

class Program
{
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool AllocConsole();

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool FreeConsole();

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool SetConsoleWindowInfo(IntPtr hConsoleOutput, bool bAbsolute, [In] ref SMALL_RECT lpConsoleWindow);

    [StructLayout(LayoutKind.Sequential)]
    public struct COORD
    {
        public short X;
        public short Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SMALL_RECT
    {
        public short Left;
        public short Top;
        public short Right;
        public short Bottom;
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetStdHandle(int nStdHandle);

    const int STD_OUTPUT_HANDLE = -11;

    static void Main()
    {
        AllocConsole();
        IntPtr hwnd = GetConsoleWindow();
        ShowWindow(hwnd, 5); // SW_SHOW

        // Set the console window size (adjust the values as needed)
        SetConsoleWindowSize(400, 300);

        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });

        Console.WriteLine("Hello from the new console window!");

        Console.ReadLine();

        FreeConsole();
    }

    static void SetConsoleWindowSize(int width, int height)
    {
        IntPtr hConsoleOutput = GetStdHandle(STD_OUTPUT_HANDLE);

        SMALL_RECT rect = new SMALL_RECT
        {
            Left = 0,
            Top = 0,
            Right = (short)(width - 1),
            Bottom = (short)(height - 1)
        };

        SetConsoleWindowInfo(hConsoleOutput, true, ref rect);
    }
}
