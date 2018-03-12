using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic8Ball.Interfaces;

namespace Magic8Ball.Input
{
    public class ConsoleInputService : IInputService
    {
        private string input = "input-initializer";

        public string GetInput()
        {
            input = Console.ReadLine();
            return input;
        }

        public bool ExitWasRequested()
        {
            return String.IsNullOrEmpty(input);
        }
    }
}
