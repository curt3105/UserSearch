using System.Xml.Serialization;

namespace UserSearch.Models;

[XmlRoot("Users", Namespace = "")]
public class UsersList
{
    [XmlElement("User")]
    public List<User> Users { get; set; }
}