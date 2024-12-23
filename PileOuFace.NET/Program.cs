bool isValid;
int reponseUserConverted = 0;

// J'intialise ma var random en dehors de ma boucle pour éviter qu'elle utilise le meme seed.
Random random = new Random();

while (true)
{
    Console.Write("Choisis si c'est PILE ou FACE: ");
    string reponseUser = Console.ReadLine();

    if (string.IsNullOrEmpty(reponseUser))
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Veuillez écrire une réponse");
        Console.ResetColor();
    }
    else if (reponseUser != "pile" && reponseUser != "PILE" && reponseUser != "face" && reponseUser != "FACE")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Vous n'êtes pas autorisé à effectuer cette action.");
        Console.ResetColor();
    }
    else if (reponseUser == "pile" || reponseUser == "PILE")
    {
        reponseUserConverted = 1;
    }
    else if (reponseUser == "face" || reponseUser == "FACE")
    {
        reponseUserConverted = 2;
    }

   
    int result = random.Next(1, 3);

    if (result == reponseUserConverted && result == 1)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Vous avez raison !!! C'était PILE.");
        Console.ResetColor();
        break;
    }
    else if (result == reponseUserConverted && result == 2)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Vous avez raison !!! C'était FACE.");
        Console.ResetColor();
        break;
    }
    else if (result != reponseUserConverted && reponseUserConverted == 1)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Vous avez perdu... c'était face.");
        Console.ResetColor();
        break;
    }
    else if (result != reponseUserConverted && reponseUserConverted == 2)
    {
        Console.Clear() ;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Vous avez perdu... c'était pile.");
        Console.ResetColor();
        break;
    }
}
