namespace WrongFacade.Systems;

// Subsystem
public class UserLogger
{
    public void Log(string name)
    {
        Console.WriteLine($"[LOG] User {name} obtained.");
    }
}