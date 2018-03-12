using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball.Interfaces
{
    public interface IOutputService
    {
        void PrintExit();
        void PrintInputPrompt();
        void PrintMessage(string message);
        void PrintWelcome();
    }
}
