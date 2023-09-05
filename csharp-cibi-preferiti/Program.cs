// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibi = { "Uova sode","Parmigiana","Pizza","Tiramisù","Trippa al sugo","Orecchiette con le cime di rapa" };

Console.WriteLine("Ecco la tua classifica di cibi preferiti:");


Console.WriteLine("Ci sono " + cibi.Length + " cibi preferiti nella tua lista");

for (int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine(i + " - " + cibi[i]);
}
