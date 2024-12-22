namespace MyNamespace;

public class MyClass2 {
    static void Main()
    {
        double number;

        while (!Double.TryParse(Console.ReadLine(), out number))
        {
            Console.Clear();
            Console.WriteLine("Veuillez entrer un nombre valide");
        }

        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine($"{i} * {number} = {number * i}");
        }
    }
    
}