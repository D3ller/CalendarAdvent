namespace MyNamespace;

public class SixDecember
{
    static void Main()
    {
        int result;
        List<int> calc = new List<int>();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Veuillez rentrer un entier");
            string number = Console.ReadLine();
            if (number == "finish" && calc.Count > 1) break;
            
            while (!Int32.TryParse(number, out result))
            {
                Console.Clear();
                Console.WriteLine("Veuillez rentrer un entier");
                number = Console.ReadLine();
            }
            
            calc.Add(result);
        }

        int results = calc.Sum();
        Console.WriteLine($"Le résultat est {results}");

    }
}