namespace Facade.Systems;

public class MessageSystem
{
    public void Send(string message)
    {
        Console.WriteLine($"[MESSAGE SYSTEM] Message Sent: {message}");
    } 
}