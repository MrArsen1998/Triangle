using DemoApp;

Person person = new("James", "Carter");

Console.WriteLine(person);

var anotherPerson = person with { LastName = "Evans" };

Console.WriteLine(anotherPerson);

Console.WriteLine(ReferenceEquals(anotherPerson, person));
Console.WriteLine(anotherPerson == person);
Console.WriteLine(anotherPerson.Equals(person));

const string S1 = $"Hello world";
const string S2 = $"Hello{" "}World";
const string S3 = $"{S1} Kevin, welcome to the team!";

var readFunc = Console.ReadLine;


if (person is { Address.City: "Caracas" })
    Console.WriteLine("Hello " + person.FirstName);

if (person.Address is null)
    Console.WriteLine("Address is null");

var fastStrategy = new FastStrategy();
var slowStrategy = new SlowStrategy();
var fastBicycle = new Bicycle(fastStrategy);
var slowBicycle = new Bicycle(slowStrategy);

await Task.WhenAll(fastBicycle.StartRiding(), slowBicycle.StartRiding());