namespace DemoApp;

public record class Person
{
    public Person(string firstName, string lastName, Address address)
    {
        if(string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentNullException(nameof(firstName));

        if(string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentNullException(nameof(lastName));

        ArgumentNullException.ThrowIfNull(address);

        Address = address;
        LastName = lastName;
        FirstName = firstName;
    }

    public void Deconstruct(out string first, out string second)
    {
        first = FirstName;
        second = LastName;
    }

    public string FirstName { get; init; }
    public string LastName { get; init; }
    public Address Address { get; set; }
}