using UserSearch.Models;
using Moq;
using UserSearch.Interfaces;
using AutoFixture;
using UserSearch.Implementations;

namespace UnitTests.UserServiceTests;

public class GetUsers
{
    [Fact]
    public void ShouldCallUserRepo()
    {
        var mockUserRepository = new Mock<IUsersRepository>();
        mockUserRepository.Setup(x => x.GetUsers()).Returns(new UsersList());
        var userService = new UserService(mockUserRepository.Object);
        userService.GetUsers();
        mockUserRepository.Verify(x=>x.GetUsers(), Times.Once);

    }
    
    [Fact]
    public void ShouldReturnListOfUsers()
    {
        var fixture = new Fixture();
        var mockUserRepository = new Mock<IUsersRepository>();
        var expectedListOfUsers = new UsersList
        {
            Users = fixture.Create<List<User>>()
        };
        mockUserRepository.Setup(x => x.GetUsers()).Returns(expectedListOfUsers);
        var userService = new UserService(mockUserRepository.Object);
        var users = userService.GetUsers();
        Assert.True(users.Count > 0);
    }
}



