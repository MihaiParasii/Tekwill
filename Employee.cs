namespace OOP_HW1;

public class Employee(string name, int salary, string department)
{
    public string Name { get; set; } = name;
    public int Salary { get; set; } = salary;
    public string Department { get; set; } = department;

    public override string ToString()
    {
        return $"Name: {Name} Salary: {Salary} Department: {Department}";
    }
}
