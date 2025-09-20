using System;
using System.Collections.Generic;

namespace Mediator;

// Mediator interface
public interface IChatRoomMediator
{
    void SendMessage(IUser sender, string message, IUser receiver);
}

// Colleague interface
public interface IUser
{
    string Name { get; }
    void SendMessage(string message, IUser receiver);
    void ReceiveMessage(string message, IUser sender);
}

// Concrete Mediator
public class ChatRoomMediator : IChatRoomMediator
{
    private readonly List<IUser> _users = [];


    public void SendMessage(IUser sender, string message, IUser receiver)
    {
            receiver.ReceiveMessage(message, sender);
    }
}

// Concrete Colleague
public class User(string name, IChatRoomMediator mediator) : IUser
{
    public string Name { get; } = name;

    public void SendMessage(string message, IUser receiver)
    {
        Console.WriteLine($"{Name} (sending): {message}");
        mediator.SendMessage(this, message, receiver);
    }

    public void ReceiveMessage(string message, IUser sender)
    {
        Console.WriteLine($"{Name} (received from {sender.Name}): {message}");
    }
}

