// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibi = { "uova sode","parmigiana","pizza","tiramisù","trippa al sugo","orecchiette con le cime di rapa" };

Console.WriteLine("Ecco la tua classifica di cibi preferiti:");


Console.WriteLine($"Ci sono  {cibi.Length}  cibi preferiti nella tua lista");

for (int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine($"{i} - {cibi[i]}");
}

Console.WriteLine($"Il tuo cibo preferito in assoluto è: {cibi[0]}");

Console.WriteLine( $"Il tuo peggior cibo preferito è: {cibi[cibi.Length - 1]}");

//BONUS


