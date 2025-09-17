using Iterator;

var numbers = new List<int> { 1, 2, 3, 4, 5 };
var iterator = new ConcreteIterator<int>(numbers);

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}

// or just using foreach
foreach (var number in numbers)
{
    Console.WriteLine(number);
}