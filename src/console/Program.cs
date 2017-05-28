using System;
using lib;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            TestInterop.PrintWithoutInterop();
            TestInterop.PrintWithInterop();
        }
    }
}
