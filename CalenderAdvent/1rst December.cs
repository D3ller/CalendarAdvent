namespace MyNamespace;

class MyClass
{
    static void Main()
    {
        var tables = new Dictionary<int, int> {};
        for (char c = 'a'; c <= 'z'; c++)
        {
            int unicode = c;
            tables.Add(unicode, 0);
        }

        string word;
        while (String.IsNullOrEmpty(word = Console.ReadLine()))
        {
            Console.Clear();
            Console.WriteLine("Veuillez entrer des caractères entre A et Z");
        }

        word = word.ToLower().Trim().Replace(" ", "");

        foreach (char l in word)
        {
            int unicode = l;
            if (tables.ContainsKey(unicode))
            {
                tables[unicode]++;
            }
        }

        var finalResult = from h in tables where h.Value > 0 select h;
        foreach (var i in finalResult)
        {
            char letter = (char) i.Key;
            Console.WriteLine($"{letter} : {i.Value}");
        }
    }
}