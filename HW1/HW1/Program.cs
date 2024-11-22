namespace HW1
{
    public class MyClasa
    {
        private int _var1;
        public string Nume;

        public static void AfiseazaNumar(int numar)
        {
            if (numar > 0)
            {
                Console.WriteLine("Numarul este pozitiv.");
            }
            else
            {
                Console.WriteLine("Numarul este negativ.");
            }
        }

        public static void CalculeazaSuma(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine("Suma numerelor este: " + suma);
        }

        public static void CalculeazaProdus(int a, int b)
        {
            int produs = a * b;
            Console.WriteLine("Produsul numerelor este: " + produs);
        }
    }


    internal static class Program
    {
        private static void Main()
        {
            MyClasa obj = new MyClasa();

            MyClasa.AfiseazaNumar(10);

            obj.Nume = "Exemplu";
            Console.WriteLine(obj.Nume);

            MyClasa.CalculeazaSuma(5, 3);
            MyClasa.CalculeazaProdus(2, 4);

            Console.ReadLine();
        }
    }
}
