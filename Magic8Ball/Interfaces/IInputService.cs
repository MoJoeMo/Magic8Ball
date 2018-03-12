using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball.Interfaces
{
    public interface IInputService
    {
        bool ExitWasRequested();
        string GetInput();
    }
}
