using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic8Ball.Interfaces;

namespace Magic8Ball
{
    public class Magic8BallSimulator
    {
        private IMessageService _messageService;
        private IInputService _inputService;
        private IOutputService _outputService;

        public Magic8BallSimulator(IMessageService messageService, IInputService inputService, IOutputService outputService)
        {
            _messageService = messageService;
            _inputService = inputService;
            _outputService = outputService;
        }

        public void Run()
        {
            _outputService.PrintWelcome();
            string message = string.Empty;

            _outputService.PrintInputPrompt();
            _inputService.GetInput();

            while (!_inputService.ExitWasRequested())
            {
                message = _messageService.GetMessage();
                _outputService.PrintMessage(message);
                _outputService.PrintInputPrompt();
                _inputService.GetInput();
            }

            _outputService.PrintExit();
        }
    }
}
