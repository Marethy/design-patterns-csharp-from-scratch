using System.Collections.Concurrent;
using System.Drawing;
namespace Flyweight;

public record Bullet(string Caliber, string Material)
{

    // Extrinsic state (unique per instance)
    public string Display(Tuple<int,int> position) => $"{Caliber} bullet made of {Material} at {position}";
}
public class BulletFactory
{
    private readonly ConcurrentDictionary<string, Bullet> _bullets = new();
    public Bullet GetBullet(string caliber, string material)
    {
        string key = $"{caliber}_{material}";
        if (!_bullets.TryGetValue(key, out Bullet? value))
        {
            value = new Bullet(caliber, material);
            _bullets[key] = value;
        }
        return value;
    }
    public int TotalBulletsCreated() => _bullets.Count;
}