// Create individual items
using Composite;

var apple = new Item("Apple", 1.2m);
var banana = new Item("Banana", 0.8m);
var orange = new Item("Orange", 1.5m);

// Create a bundle with a discount
var fruitBundle = new ItemBundle("Fruit Bundle", discount: 0.5m);
fruitBundle.AddItem(apple);
fruitBundle.AddItem(banana);
fruitBundle.AddItem(orange);

// Create another item
var milk = new Item("Milk", 2.0m);

// Create a super bundle that includes the fruit bundle and milk
var superBundle = new ItemBundle("Super Bundle", discount: 1.0m);
superBundle.AddItem(fruitBundle);
superBundle.AddItem(milk);

// Print details
PrintCartItem(apple);
PrintCartItem(fruitBundle);
PrintCartItem(superBundle);


static void PrintCartItem(ICartItem item, int indent = 0)
{
    var indentStr = new string(' ', indent * 2);
    Console.WriteLine($"{indentStr}- {item.Name}: ${item.Price:F2}");

    if (item is ItemBundle bundle)
    {
        foreach (var child in typeof(ItemBundle)
            .GetField("_items", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            ?.GetValue(bundle) as System.Collections.Generic.IEnumerable<ICartItem> ?? [])
        {
            PrintCartItem(child, indent + 1);
        }
    }
}