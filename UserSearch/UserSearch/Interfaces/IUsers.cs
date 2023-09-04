using UserSearch.Models;

namespace UserSearch.Interfaces;

public interface IUsers
{
    List<User> GetUsers();
}