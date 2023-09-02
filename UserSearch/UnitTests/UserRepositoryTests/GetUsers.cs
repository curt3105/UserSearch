using UserSearch.Implementations;
using UserSearch.Models;

namespace UnitTests.UserRepositoryTests;

public class GetUsers
{
    [Fact]
    public void ShouldReturnAListOfUsers()
    {
        var repo = new UserRepository();
        var userList = repo.GetUsers();
        Assert.True(userList.Users.Count > 0);
    }
}