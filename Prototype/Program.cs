using Prototype;

Product laptop = new Product("Gaming Laptop", 1500m, "Electronics");

// Clone từ prototype
Product laptopStudent = (Product)laptop.Clone();
laptopStudent.Name = "Student Laptop";  
laptopStudent.Price = 1200m;

Product laptopPremium = (Product)laptop.Clone();
laptopPremium.Name = "Premium Laptop";
laptopPremium.Price = 2000m;

Console.WriteLine(laptop);
Console.WriteLine(laptopStudent);
Console.WriteLine(laptopPremium);