namespace Decorator;

// Concrete Component
public class Weapon : IWeapon
{
    public void Mount()
    {
        Console.WriteLine("Mounting the weapon");
    }

    public double Price { get; set; } = 200;
}