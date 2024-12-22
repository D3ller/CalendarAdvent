using System.Text.RegularExpressions;

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

        phrase = phrase.ToLower();
        string pattern = "[^a-z ]";

        int vowelCount = 0;
        int consonantCount = 0;
        string vowels = "aeiouy";
        string consonant = "bcdfghjklmnpqrstvwxyz";
        phrase = Regex.Replace(phrase, pattern, String.Empty).Replace(" ", String.Empty);
        Console.WriteLine(phrase);

        foreach (char c in phrase)
        {
            foreach (char v in vowels)
            {
                if (c == v)
                {
                    vowelCount++;
                }
            }

            foreach (char v in consonant)
            {
                if (c == v)
                {
                    consonantCount++;
                }
            }
        }
        
        Console.WriteLine(vowelCount + " " + consonantCount);
    }
    
}