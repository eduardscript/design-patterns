namespace Facade.Systems;

public class UserLogger
{
    public void Log(string name)
    {
        Console.WriteLine($"[LOG] User {name} obtained.");
    }
}