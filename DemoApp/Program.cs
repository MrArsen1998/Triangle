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

object obj = new { };

Console.WriteLine(sizeof(byte));
Console.WriteLine(sizeof(char));
Console.WriteLine(sizeof(short));
Console.WriteLine(sizeof(int));
Console.WriteLine(sizeof(long));

Console.WriteLine();

Console.WriteLine(sizeof(float));
Console.WriteLine(sizeof(double));
Console.WriteLine(sizeof(decimal));

Console.WriteLine();

Console.WriteLine(sizeof(uint));
Console.WriteLine(sizeof(uint));
Console.WriteLine(sizeof(ulong));
Console.WriteLine(sizeof(ushort));

await ClientApplication.Main();

await Task.WhenAll(fastBicycle.StartRiding(), slowBicycle.StartRiding());

// We need:
// a product that knows what it can do
// a creator of that product which gives a handle for creating the product
// a client Code who choses one specific creator and uses the products Operation() function

interface ICar
{
    void Drive();
}

record CountryCar : ICar
{
    public void Drive() => Console.WriteLine("Driving a Country Car");
}

record SportCar : ICar
{
    public void Drive() => Console.WriteLine("Driving a Sport Car");
}

interface ICarFactory
{
    ICar CreateCar();
}

record SportCarFactory : ICarFactory
{
    public ICar CreateCar() => new SportCar();
}

record CountryCarFactory : ICarFactory
{
    public ICar CreateCar() => new CountryCar();
}

record ClientApplication
{ 
    private static void ExecuteAppCode(ICarFactory carFactory)
    {
        var car = carFactory.CreateCar();

        car.Drive();
    }

    public static async Task Main()
    {
        ICarFactory sportCarFactory = new SportCarFactory();
        ICarFactory countryCarFactory = new CountryCarFactory();

        ExecuteAppCode(sportCarFactory);

        await Task.Delay(1000);

        ExecuteAppCode(countryCarFactory);
    }
}