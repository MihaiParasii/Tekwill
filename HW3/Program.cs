namespace HW3;

static class Program
{
    private static void Main()
    {
        Ex3();
    }

    private static void Ex1()
    {
        Console.Write("Input your birthday dd.mm.yyyy: ");
        string input = Console.ReadLine()!;
        DateTime birthDate = DateTime.Parse(input);
        TimeSpan age = DateTime.Now - birthDate;
        Console.WriteLine($"You are {age.Days} days old");
    }

    private static void Ex2()
    {
        Student student = ReadStudent();
        Console.WriteLine(student.ToString());
    }

    private static Student ReadStudent()
    {
        Console.Write("Input student name: ");
        string name = Console.ReadLine()!;

        Console.Write("Input student age: ");
        int age = int.Parse(Console.ReadLine()!);

        Console.Write("Input student speciality: ");
        string speciality = Console.ReadLine()!;

        Console.Write("Input student year of study (I-VI): ");
        YearOfStudy yearOfStudy = (YearOfStudy)Enum.Parse(typeof(YearOfStudy), Console.ReadLine()!, true);

        return new Student { Name = name, Age = age, Speciality = speciality, YearOfStudy = yearOfStudy };
    }

    private struct Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Speciality { get; set; }
        public YearOfStudy YearOfStudy { get; set; }

        public override string ToString()
        {
            return $"\tName: {Name}\n\tAge: {Age}\n\tSpeciality:{Speciality}\n\tYear of study:{YearOfStudy}\n";
        }
    }

    private enum YearOfStudy
    {
        I,
        II,
        III,
        IV,
        V,
        VI
    }

    private static void Ex3()
    {
        Point circleCenter = new Point { X = 5, Y = 5 };
        const int circleRadius = 3;
        Circle circle = new Circle { Center = circleCenter, Radius = circleRadius };
        Console.WriteLine($"Circle center: ({circle.Center.X}, {circle.Center.Y}), radius: {circle.Radius}");
        ChangeCenterCoords(circle.Center);
        Console.WriteLine($"Updated circle center: ({circle.Center.X}, {circle.Center.Y})");
        ChangeCircleRadius(circle);
        Console.WriteLine($"Updated circle radius: {circle.Radius}");
        
        
    }

    private static void ChangeCenterCoords(Point point)
    {
        point.X = point.X + 1;
        point.Y = point.Y + 1;
    }

    private static void ChangeCircleRadius(Circle circle)
    {
        circle.Radius = circle.Radius + 1;
    }

    private struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    private class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }
}
