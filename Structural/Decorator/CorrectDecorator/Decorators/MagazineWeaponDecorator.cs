namespace Decorator.Decorators;

public enum MagazineSize
{
    Standard = 32,
    Medium = 64,
    Maximum = 128,
}

// Concrete Decorator
public class MagazineWeaponDecorator : BaseWeaponDecorator
{
    private readonly MagazineSize _magazineSize;
    public MagazineWeaponDecorator(IWeapon innerWeapon, MagazineSize magazineSize) : base(innerWeapon)
    {
        _magazineSize = magazineSize;
    }

    public override void Mount()
    {
        base.Mount();
        Console.WriteLine("Mounting the magazine!");
    }

    public override double Price => base.Price + CalculatePrice();

    private double CalculatePrice() => _magazineSize switch
    {
        MagazineSize.Standard => 50.0,
        MagazineSize.Medium => 50.0,
        MagazineSize.Maximum => 50.0,
        _ => throw new ArgumentOutOfRangeException(nameof(_magazineSize), $"Not expected magazine size: {_magazineSize}"),
    };
}
