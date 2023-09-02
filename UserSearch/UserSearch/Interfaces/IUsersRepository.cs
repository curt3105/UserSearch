using UserSearch.Models;

namespace UserSearch.Interfaces;

public interface IUsersRepository
{
    UsersList GetUsers();
}