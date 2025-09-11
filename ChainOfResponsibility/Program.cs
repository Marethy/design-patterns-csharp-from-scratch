using System;
using ChainOfResponsibility;

// -----------------------
// Client code
// -----------------------
string[] requests = { "A", "B", "C", "D" };

// Build the chain only once: A → B → C
var handlerA = new ConcreteHandlerA();
var handlerB = new ConcreteHandlerB();
var handlerC = new ConcreteHandlerC();

handlerA.SetNext(handlerB).SetNext(handlerC);

// Now test with requests
foreach (var request in requests)
{
    Console.WriteLine($"\nClient: Who wants to handle {request}?");
    handlerA.Handle(request); // start at the head of the chain
}
