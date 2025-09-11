using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // Command interface
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver
    public class Light
    {
        public void On() => Console.WriteLine("The light is on.");
        public void Off() => Console.WriteLine("The light is off.");
    }

    //Concrete Command for turning on the light
    public class LightOnCommand(Light light) : ICommand
    {
        public void Execute() => light.On(); 
        public void Undo() => light.Off();
    }
    public class LightOffCommand(Light light) : ICommand
    {
        public void Execute() => light.Off();
        public void Undo() => light.On();
    }

    // Invoker
    public class RemoteControl
    {
        private ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void PressButton()
        {
            _command.Execute();
        }
        public void PressUndo()=> _command.Undo();
    }

}
