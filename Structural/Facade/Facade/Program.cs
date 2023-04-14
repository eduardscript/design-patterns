namespace WrongFacade;

public class Program
{
    public static void Main()
    {
        // Client
        IUserFacade userFacade = new UserFacade();
        
        userFacade.SendMessageToAllUsers();
    }
}