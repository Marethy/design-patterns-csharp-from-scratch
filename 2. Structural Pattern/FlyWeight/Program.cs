using Flyweight;

var factory = new BulletFactory();


for (int i = 0; i < 100; i++)
{
    var prototype = factory.GetBullet("5.56mm", "Brass");
    Console.WriteLine(prototype.Display(new (i, i * 2))); // 100 bullets, but only 1 type
}
Console.WriteLine($"Total bullet types created: {factory.TotalBulletsCreated()}");
