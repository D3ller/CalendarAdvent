namespace MyNamespace;

public class FourDecember {
    static void Main()
    {
        Console.WriteLine("Entrez une phrase svp");
        string phrase = Console.ReadLine();
        while (String.IsNullOrEmpty(phrase))
        {
            Console.WriteLine("Veuillez entrer une phrase valide");
            phrase = Console.ReadLine();
        }

        int vowelCount = 0;
        string vowels = "aeiouy";

        foreach (char c in phrase)
        {
            foreach (char v in vowels)
            {
                if (c == v)
                {
                    vowelCount++;
                }
            } 
        }
        
        Console.WriteLine(vowelCount);
    }
    
}