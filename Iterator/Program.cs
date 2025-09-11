using Iterator;

var numbers = new NumberCollection();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

var iterator = numbers.GetIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}
        