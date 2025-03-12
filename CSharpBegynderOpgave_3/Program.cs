//Lav et spil hvor man kan gætte et, af computeren, random genereret tal.
Random random = new Random();
int resultat = random.Next(0, 101); //Generere et random tal imellem 0 og 100. (0 er med, men 101 er ikke)
bool snyd = true;
if(snyd == true)
{
    Console.WriteLine("Snyd er slået til! Tallet er " + resultat);
}
Console.WriteLine("Gæt på et tal fra 0-100:");
int gæt = Convert.ToInt32(Console.ReadLine()); //Det giver altså en fejl hvis vi taster noget ind som IKKE er et tal!

if (gæt == resultat)
{
    Console.WriteLine("Dit gæt, " + gæt + ", var rigtigt");
}
else if (resultat<50)
{
    Console.WriteLine("Dit gæt, " + gæt + ", var ikke rigtigt. Du får et hint: Tallet er mindre end 50");
}
else
{
    Console.WriteLine("Dit gæt, " + gæt + ", var ikke rigtigt. Du får et hint: Tallet er større end 50");
}

Console.ReadKey();