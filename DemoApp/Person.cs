namespace DemoApp;

public record class Person
{
    public Person(string firstName, string lastName)
    {
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