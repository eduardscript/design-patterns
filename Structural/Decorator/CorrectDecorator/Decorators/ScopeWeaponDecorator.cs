namespace Decorator.Decorators;

// Concrete Decorator
public class ScopeWeaponDecorator : BaseWeaponDecorator
{
    public ScopeWeaponDecorator(IWeapon innerWeapon) : base(innerWeapon)
    {
    }

    public override void Mount()
    {
        base.Mount();
        Console.WriteLine("Mounting the scope!");
    }

    public override double Price => base.Price + 200.0;
}