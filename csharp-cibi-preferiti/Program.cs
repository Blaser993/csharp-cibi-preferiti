// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibi = { "uova sode","parmigiana","tiramisù","trippa al sugo","orecchiette con le cime di rapa" };

Console.WriteLine("Ecco la tua classifica di cibi preferiti:");


Console.WriteLine($"Ci sono  {cibi.Length}  cibi preferiti nella tua lista.");

for (int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine($"{i} - {cibi[i]}");
}

Console.WriteLine($"Il tuo cibo preferito in assoluto è: {cibi[0]}.");

Console.WriteLine( $"Il tuo peggior cibo preferito è: {cibi[cibi.Length - 1]}.");

//BONUS

int ciboMediano = 0;

if (cibi.Length % 2 == 0)
{
     ciboMediano = cibi.Length / 2;
    Console.WriteLine($"Il tuo cibo mediamente preferito è: {cibi[ciboMediano]}.");
}
else if (cibi.Length % 2 == 1)
{
    double lunghezzaMedia = Convert.ToDouble(cibi.Length)/2;

    //Console.WriteLine($"lunghezza media = {lunghezzaMedia}");

    lunghezzaMedia = Math.Round(lunghezzaMedia);

    int lunghezzaMedia2 = Convert.ToInt32(lunghezzaMedia);

    int lunghezzaMedia1 = Convert.ToInt32(lunghezzaMedia) - 1;

    //Console.WriteLine($"lunghezza media = {lunghezzaMedia}");

    Console.WriteLine($"I tuoi cibi mediamente preferiti sono: {cibi[lunghezzaMedia2]} e {cibi[lunghezzaMedia1]}.");
}


