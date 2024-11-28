namespace HW4;

internal static class Program
{
    private static void Main()
    {
        Ex3();
    }

    private static void Ex1()
    {
        object obj1 = "string object";
        object obj2 = 123;
        object obj3 = true;
        object obj4 = 1.2;

        PrintType(obj1);
        PrintType(obj2);
        PrintType(obj3);
        PrintType(obj4);
    }

    private static void PrintType(object obj)
    {
        switch (obj)
        {
            case string s:
                Console.WriteLine($"Type: string, Value: {s}");
                Console.WriteLine(s.Length > 5 ? "String is long" : "String is short");
                break;
            case int num:
                Console.WriteLine($"Type: int, Value: {num}");
                Console.WriteLine(num % 1 == 0 ? $"{num} is even" : $"{num} is odd");
                break;
            case bool b:
                Console.WriteLine($"Type: bool, Value: {b}");
                break;
            default:
                Console.WriteLine($"Unknown type, System Type {obj.GetType()}, Value {obj}");
                break;
        }
    }

    private static void Ex2()
    {
        int[] marks = [10, 5, 7, 1, 8, 9, 3, -1];

        foreach (int mark in marks)
        {
            Console.WriteLine(mark + " — " + GetMarkName(mark));
        }
    }

    private static string GetMarkName(int mark) =>
        mark switch
        {
            10 => "Excelent",
            > 8 => "Bun",
            >= 5 => "Satisfactor",
            >= 1 => "Necalificat",
            _ => "Wrong mark"
        };


    private static void Ex3()
    {
        MenuObject menuObject1 = new MenuObject { Menu = Menu.Supa, Name = "Supa", Description = "Supa descriere", Price = 55};
        MenuObject menuObject2 = new MenuObject { Menu = Menu.SalatCaesar, Name = "Salata Caesar", Description = "Salata Caesar descriere", Price = 60};
        MenuObject menuObject3 = new MenuObject { Menu = Menu.SalatGrecesc, Name = "Salata Greceasca", Description = "Salata Greceasca descriere", Price = 65};
        MenuObject menuObject4 = new MenuObject { Menu = Menu.Inghetata, Name = "Inghetata", Description = "Inghetata descriere", Price = 20};

        int input = 1;

        while (input != 0)
        {
            PrintMenu();
            int.TryParse(Console.ReadLine(), out input);

            switch (input)
            {
                case (int)Menu.Supa:
                    Console.WriteLine(menuObject1);
                    break;
                case (int)Menu.SalatCaesar:
                    Console.WriteLine(menuObject2);
                    break;
                case (int)Menu.SalatGrecesc:
                    Console.WriteLine(menuObject3);
                    break;
                case (int)Menu.Inghetata:
                    Console.WriteLine(menuObject4);
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }


    }

    private static void PrintMenu()
    {
        Console.WriteLine("--- Meniu ---");
        Console.WriteLine("1 — Supa");
        Console.WriteLine("2 — Salata Caesar");
        Console.WriteLine("3 — Salata Greceasca");
        Console.WriteLine("4 — Inghetata");
        Console.WriteLine("0 — Exit");
        Console.WriteLine("——————————————");
    }

    private struct MenuObject
    {
        public Menu Menu { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        
        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, Price: {Price}";
        }
    }

    private enum Menu
    {
        Supa = 1,
        SalatCaesar,
        SalatGrecesc,
        Inghetata
    }
}
