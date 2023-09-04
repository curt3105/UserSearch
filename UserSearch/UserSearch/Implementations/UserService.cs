using UserSearch.Interfaces;
using UserSearch.Models;

namespace UserSearch.Implementations;

public class UserService : IUsers
{
    private readonly IUsersRepository _repository;

    public UserService(IUsersRepository repository)
    {
        _repository = repository;
    }
    public List<User> GetUsers()
    {
        var result = _repository.GetUsers();
        return result.Users;
    }
}