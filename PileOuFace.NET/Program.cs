
bool isValid;



while (true)
{
    Console.Write("Choisis si c'est pile ou face:";
    string reponseUser = Console.ReadLine();


    if (string.IsNullOrEmpty(reponseUser))
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Veuillez écrire une réponse");
        Console.ResetColor();
    } 
    else if (reponseUser != "pile" || reponseUser != "PILE" || reponseUser != "face"|| reponseUser != "FACE")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Vous n'étes pas autorisée a effectuer cette action.");
        Console.ResetColor();
    }

}