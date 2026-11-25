List<string> ukoly = new();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 - Přidat úkol");
    Console.WriteLine("2 - Vypsat úkoly");
    Console.WriteLine("0 - Konec");
    Console.Write("Vyber akci: ");

    string? volba = Console.ReadLine();

    if (volba == "1")
    {
        Console.Write("Zadej nový úkol: ");
        string? ukol = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(ukol))
        {
            ukoly.Add(ukol.Trim());
            Console.WriteLine("Úkol byl uložen.");
        }
        else
        {
            Console.WriteLine("Prázdný úkol nelze uložit.");
        }
    }
    else if (volba == "2")
    {
        Console.WriteLine();
        Console.WriteLine("Seznam úkolů:");

        if (ukoly.Count == 0)
        {
            Console.WriteLine("Žádné úkoly nejsou uloženy.");
        }
        else
        {
            foreach (string ukol in ukoly)
            {
                Console.WriteLine($"• {ukol}");
            }
        }
    }
    else if (volba == "0")
    {
        break;
    }
    else
    {
        Console.WriteLine("Neplatná volba.");
    }
}