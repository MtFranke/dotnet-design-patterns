namespace DDP.CQRS.Domain;

public class User
{
    public string FirstName { get; }
    public string LastName { get; }

    public User(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    string FullName()
    {
        if (string.IsNullOrWhiteSpace(FirstName))
            throw new ArgumentException("First name cannot be null or empty");
    
        if (string.IsNullOrWhiteSpace(LastName))
            throw new ArgumentException("Last name cannot be null or empty");
    
        return $"{FirstName} {LastName}";
    }
}