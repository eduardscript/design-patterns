using Decorator.Repositories;

// Concrete component
namespace Decorator;

public class UsersService : IUsersService
{
    private readonly UserRepository _repo;

    public UsersService(UserRepository repo)
    {
        _repo = repo;
    }    
    
    public IEnumerable<User> GetAllUsers()
    {
        return _repo.Users;
    }
}