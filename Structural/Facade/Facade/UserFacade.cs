using WrongFacade.Systems;

namespace WrongFacade;

// Facade (implementation)
public class UserFacade : IUserFacade
{
    public void SendMessageToAllUsers()
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