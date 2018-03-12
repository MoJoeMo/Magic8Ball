using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Magic8Ball.Input;
using Magic8Ball.Interfaces;
using Magic8Ball.Messages;
using Magic8Ball.Output;

namespace Magic8Ball.Startup
{
    public class ContainerSetup
    {
        private ContainerBuilder builder;
        string outputFilePath = Path.Combine(Path.GetTempPath(), "magic8BallOutput.txt");

        public IContainer BuilderContainer()
        {
            builder = new ContainerBuilder();

            builder.RegisterType<ConsoleInputService>().As<IInputService>();
            builder.RegisterType<Magic8BallSimulator>();
            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.Register(c => new MultipleOutputService(outputFilePath)).As<IOutputService>();

            return builder.Build();
        }
    }
}
