using System.Xml.Serialization;

namespace UserSearch.Models;

public class User
{
    [XmlAttribute("id")]
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    [XmlElement("IsBusinessContact")]
    public bool IsBusinessContact { get; set; }
    [XmlElement("IsAccountingContact")]
    public bool IsAccountingContact { get; set; }
    [XmlElement("IsTechnicalContact")]
    public bool IsTechnicalContact { get; set; }
    [XmlElement("HasApiAccess")]
    public bool HasApiAccess { get; set; }
}