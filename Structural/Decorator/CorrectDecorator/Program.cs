using Decorator.Decorators;

namespace Decorator;

public class Program
{
    public static void Main()
    {
        var concreteComponent = new Weapon();

        var magazineDecorator = new MagazineWeaponDecorator(concreteComponent, MagazineSize.Medium);

        var scopeDecorator = new ScopeWeaponDecorator(magazineDecorator);

        scopeDecorator.Mount();
    }
}
