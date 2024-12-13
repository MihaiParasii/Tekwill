namespace OOP_HW1;

public abstract class Person(string name, string surname, int age)
{
    protected string Name { get; init; } = name;
    protected string Surname { get; init; } = surname;
    protected int Age { get; set; } = age;
}

public class IndividualPerson(string name, string surname, int age, long idnp) : Person(name, surname, age)
{
    public long Idnp { get; init; } = idnp;

    public override string ToString() => $"IndividualPerson: {Name} {Surname}, Age: {Age}, IDNP: {Idnp}\n";
}

public class BusinessPerson(string name, string surname, int age, string registrationNumber)
    : Person(name, surname, age)
{
    public string RegistrationNumber { get; init; } = registrationNumber;

    public override string ToString() =>
        $"BusinessPerson: {Name} {Surname}, Age: {Age}, Registration Number: {RegistrationNumber}";
}
