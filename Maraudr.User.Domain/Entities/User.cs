using Maraudr.Domain.ValueObjects;

namespace Maraudr.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Firstname { get; private set; }
    public string Lastname { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime LastLoggedIn { get; private set; }
    public bool IsActive { get; private set; }
    
    public ContactInfo ContactInfo { get; private set; }
    public Address Address { get; private set; }
    public AccountType AccountType { get; private set; }


    public User(Guid id, string firstname, string lastname, DateTime createdAt, DateTime lastLoggedIn, bool isActive,
        ContactInfo contactInfo, Address address, AccountType accountType)
    {
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
        LastLoggedIn = DateTime.Now;
        IsActive = true;
        ContactInfo = contactInfo;
        Address = address;
        AccountType = accountType;
    }
    
    private User() { }
    
    
}
