using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Magic8Ball.Interfaces;
using Magic8Ball.Messages;
using Magic8Ball.Output;
using Magic8Ball.Input;
using Magic8Ball.Startup;

namespace Magic8Ball
{
    public class SimulationRunner
    {
        static void Main(string[] args)
        {
            ContainerSetup containerSetup = new ContainerSetup();
            IContainer container = containerSetup.BuilderContainer();
            container.Resolve<Magic8BallSimulator>().Run();
        }
    }
}
