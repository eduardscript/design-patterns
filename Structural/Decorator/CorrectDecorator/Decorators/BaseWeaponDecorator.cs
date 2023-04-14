namespace Decorator.Decorators;

// Base Decorator
public class BaseWeaponDecorator : IWeapon
{
    private readonly IWeapon _innerWeapon;

    protected BaseWeaponDecorator(IWeapon innerWeapon)
    {
        _innerWeapon = innerWeapon;
    }
    
    public virtual void Mount()
    {
        _innerWeapon.Mount();
    }

    public virtual double Price { get; }
}