namespace Decorator;

public enum MagazineSize
{
    Standard = 32,
    Medium = 64,
    Maximum = 128,
}

public class MagazineWeapon : Weapon
{
    private readonly MagazineSize _magazineSize;
    public MagazineWeapon(MagazineSize magazineSize)
    {
        _magazineSize = magazineSize;
    }

    public override void Mount()
    {
        base.Mount();
        Console.WriteLine("Mounting the magazine!");
    }
    
    protected override double Price => base.Price + CalculatePrice();

    private double CalculatePrice() => _magazineSize switch
    {
        MagazineSize.Standard => 50.0,
        MagazineSize.Medium => 50.0,
        MagazineSize.Maximum => 50.0,
        _ => throw new ArgumentOutOfRangeException(nameof(_magazineSize), $"Not expected magazine size: {_magazineSize}"),
    };
}