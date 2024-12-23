namespace MyNamespace;

public class FiveDecember
{
    static void Main()
    {
        int[] dice = new int[6];
        Random rnd = new Random();

        for (int i = 0; i < 100; i++)
        {
            int number = rnd.Next(1, 7);
            dice[number-1]++;
        }
        
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Face {i+1} : {dice[i]}");
        }
    }
}