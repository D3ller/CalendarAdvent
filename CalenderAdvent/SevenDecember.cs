namespace MyNamespace;

public class SevenDecember
{

    static void Main()
    {
        int result;
        List<int> table = new List<int>();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Veuillez rentrer un entier");
            string number = Console.ReadLine();
            if (number == "finish" && table.Count > 1) break;
            
            while (!Int32.TryParse(number, out result))
            {
                Console.Clear();
                Console.WriteLine("Veuillez rentrer un entier");
                number = Console.ReadLine();
            }
            
            table.Add(result);
        }
    
        int results = table.Max();
        Console.WriteLine($"Le résultat max est {results}");
    
    }

}