using Facade.Systems;

namespace Facade;

public class Program
{
    public static void Main()
    {
        var database = new Database();
        var logger = new UserLogger();
        var messageSystem = new MessageSystem();

        foreach (var user in database.GetUsers())
        {
            logger.Log(user.Name);
            messageSystem.Send(user.Name);
        }
    }
}