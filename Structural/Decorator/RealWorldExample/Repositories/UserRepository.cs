namespace Decorator.Repositories;

public class UserRepository
{
    public List<User> Users { get; set; } = new()
    {
        new User("Joseph", 25),
        new User("Fanny", 33),
        new User("Eduard", 22),
        new User("Walter", 45),
    };
}