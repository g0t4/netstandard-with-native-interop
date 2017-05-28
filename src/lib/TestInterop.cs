using System;
using System.Runtime.InteropServices;

namespace lib
{
    public static class TestInterop
    {
        // Import the libc and define the method corresponding to the native function.
        [DllImport("libSystem.dylib")]
        private static extern int getpid();

        public static void PrintWithInterop()
        {
            // Invoke the function and get the process ID.
            int pid = getpid();
            Console.WriteLine($"Process id via libSystem.dylib: {pid}");
        }

        public static void PrintWithoutInterop()
        {
            System.Console.WriteLine("Hello World - no interop here");
        }
    }
}
