using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Magic8Ball.Interfaces;

namespace Magic8Ball.Output
{
    public class ConsoleOutputService : IOutputService
    {
        public void PrintExit()
        {
            Console.WriteLine("Goodbye");
            Thread.Sleep(850);
        }

        public void PrintInputPrompt()
        {
            Console.WriteLine("Ask a Question, or press \"Enter\" to exit");
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Magic 8 Ball simulator.");
        }
    }
}
