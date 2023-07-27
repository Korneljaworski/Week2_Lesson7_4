public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program w C#, który sprawdzi czy podany przez użytkownika jest rokiem przestępnym.
            Dane testowe : 2016
            Rezultat w terminalu :    2016 jest rokiem przestępnym
        */

        Console.WriteLine("Podaj rok:");

        int chosenYear = Int32.Parse(Console.ReadLine());

        if ((chosenYear % 4 == 0 && chosenYear % 100 != 0) || chosenYear % 400 == 0)
        {
            Console.WriteLine($"{chosenYear} jest rokiem przestępnym");
        }
        else
        {
            Console.WriteLine($"{chosenYear} nie jest rokiem przestępnym");
        }
    }

}
