using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;
using UserSearch.Interfaces;
using UserSearch.Models;

namespace UserSearch.Implementations;

public class UserRepository : IUsersRepository
{
    public UsersList GetUsers()
    {
        var users = new UsersList();
        try
        {
            using (XmlReader stream = XmlReader.Create("UsersTest.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UsersList));
                users = (UsersList)serializer.Deserialize(stream);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        // var jsonContent = File.ReadAllText("UsersTest.xml");
        // var users = JsonSerializer.Deserialize<List<Users>>(jsonContent);
        return users;
    }
}