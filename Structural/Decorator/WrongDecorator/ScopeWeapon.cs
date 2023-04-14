namespace Decorator;

public class ScopeWeapon : Weapon
{
    public override void Mount()
    {
        base.Mount();
        Console.WriteLine("Mounting the scope!");
    }

    protected override double Price => base.Price + 200.0;
}