using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Magic8Ball.Interfaces;
using System.Windows;


namespace Magic8Ball.Output
{
    public class MultipleOutputService : IOutputService
    {
        private string _outputFilePath = string.Empty;

        public MultipleOutputService(string outputFilePath)
        {
            _outputFilePath = outputFilePath;
        }

        public void PrintExit()
        {
            Console.WriteLine("Thanks for using the Magic 8-Ball Simulator, Goodbye");
            Thread.Sleep(850);
        }

        public void PrintInputPrompt()
        {
            Console.WriteLine("Ask a Question, or press [Enter] to exit >>");
        }

        private string _message = string.Empty;

        public void PrintMessage(string message)
        {
            _message = message;
            WriteMessageToConsole();
            WriteMessageToFile();
        }

        private void WriteMessageToConsole()
        {
            Console.WriteLine(_message);
        }

        private void WriteMessageToFile()
        {
            File.AppendAllText(_outputFilePath, _message);
        }

        public void PrintWelcome() {
			Console.WriteLine("Welcome to the Magic 8 Ball simulator");
		}
    }
}
