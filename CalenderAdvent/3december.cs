namespace MyNamespace;

public class ThreeDecember {
    static void Main()
    {
        Console.WriteLine("Entrez un mot svp");
        string palindrome = Console.ReadLine();
        while (String.IsNullOrEmpty(palindrome))
        {
            Console.WriteLine("Veuillez entrer un mot valide");
            palindrome = Console.ReadLine();
        }

        string reversedString = new string(palindrome.Replace(" ", "").ToLower().Reverse().ToArray());
        Console.WriteLine(reversedString);
        if (palindrome == reversedString)
        {
            Console.WriteLine("La chaîne est un palindrome");
            return;
        }
        Console.WriteLine("La chaîne n'est pas un palindrome");
    }
    
}