namespace Taschenrechner {
    internal class Program {
        static void Main(string[] args) {

            char op;
            string input;

            Console.Write("Zahl 1: ");
            input = Console.ReadLine()!.Replace(',', '.');
            if (double.TryParse(input, out double z1)) {
            } else {
                throw new ArgumentException("Ungültige Eingabe!");
            }

            Console.Write("Zahl 2: ");
            input = Console.ReadLine()!.Replace(',', '.');
            if (double.TryParse(input, out double z2)) {
            } else {
                throw new ArgumentException("Ungültige Eingabe");
            }

            Console.Write("Operator: ");
            op = Console.ReadKey().KeyChar;
            Console.WriteLine("Hallo from Dev");

            Console.WriteLine($"{z1} {op} {z2} = {Berechnung.rechnen(z1, z2, op)}");
        }
    }
}
