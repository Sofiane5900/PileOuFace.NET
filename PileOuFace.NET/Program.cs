
bool isValid;
// Je donne une valeur de défault avant de lui en assigner une autre, sinons erreur du compileur.
int reponseUserConverted = 0;




while (true)
{
    Console.Write("Choisis si c'est pile ou face:");
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
    } else if (reponseUser == "pile" || reponseUser == "PILE")
    {
        reponseUserConverted = 1;
    }

    else if (reponseUser == "face" || reponseUser == "FACE")
    {
        reponseUserConverted = 2;
    }

    Random random = new Random();
    int result = random.Next(1,2);

    if (result == reponseUserConverted)
    {

    }


}