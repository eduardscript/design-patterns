namespace Decorator;

public class Weapon
{
    public virtual void Mount()
    {
        Console.WriteLine("Mounting the weapon");
    }
    
    protected virtual double Price { get; set; } = 200;
}