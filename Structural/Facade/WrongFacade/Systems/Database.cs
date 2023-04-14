namespace Facade.Systems;

public class Database
{
    private List<User> _users = new()
    {
        new User("Eduard"),
        new User("Massas"),
        new User("Ricco"),
        new User("Astrona"),
    };
    
    public IEnumerable<User> GetUsers()
    {
        return _users;
    } 
}