using System;
namespace Command;
public interface ICommand
{
    void Execute();
    void Undo();
}

public record Light(string Name)
{
    public void TurnOn() => Console.WriteLine($"{Name} turned on");
    public void TurnOff() => Console.WriteLine($"{Name} turned off");
}

public class LightCommand(Light light) : ICommand
{
    public void Execute() => light.TurnOn();
    public void Undo() => light.TurnOff();
}

public class Remote(ICommand command)
{
    public void PressButton() => command.Execute();
    public void PressUndo() => command.Undo();
}
public class UserVoice(ICommand command)
{
    public void TalkTurnOn() => command.Execute();
    public void TalkTurnOff() => command.Undo();
}

