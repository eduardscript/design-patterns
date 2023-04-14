namespace Decorator;

public class Program
{
    public static void Main()
    {
        ScopeMagazineWeapon component = new(MagazineSize.Standard);
        
        component.Mount();
    }
}