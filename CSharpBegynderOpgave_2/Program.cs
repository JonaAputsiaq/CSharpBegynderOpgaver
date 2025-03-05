/*   Opgave 2
    - Udvid dit visitkort fra sidst ved at gøre brug af Forskellige datatyper, variabler og user input.
    - Se bunden af koden for eksempler
 */
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

Console.WriteLine("ASCII Visitkort generator" + " (tilføj dato her senere)");
int xPosition = 0;
int yPosition = 2;
Console.SetCursorPosition(xPosition, yPosition);
Console.WriteLine("Vær venlig at taste følgende for at præge dit visitkort:");
Console.WriteLine("Dit navn?");
string navn = Console.ReadLine();
Console.WriteLine("Din alder?");
int alder = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ønsker du overskriften 'interesser' på dit visitkort? (Skriv 'ja' eller 'nej')");
string inkluderInteresser = Console.ReadLine().ToLower();
string interesser = "";
if(inkluderInteresser == "ja")
{
    Console.WriteLine("Dine interesser? (interesser vises som de skrives, så husk komma og mellemrum)");
    interesser = Console.ReadLine();
}

Console.WriteLine("Ønskede farve til visitkortet? (Skriv enten 'grøn', 'rød' eller 'blå'. Hvis intet er skrevet, eller noget er stavet forkert, forbliver teksten hvid.)");
string farve = Console.ReadLine();
if (farve == "grøn")
{
    Console.ForegroundColor = ConsoleColor.Green;
}
else if (farve == "rød")
{
    Console.ForegroundColor = ConsoleColor.Red;
}
else if (farve == "blå")
{
    Console.ForegroundColor = ConsoleColor.Blue;
}

    Console.WriteLine("Visitkortet kan kopieres her under:");
Console.WriteLine("========================================");
Console.WriteLine("|             MIT VISITKORT            |");
Console.WriteLine("========================================\n");
Console.WriteLine("========================================");
Console.WriteLine("|               Navn:                   |");
Console.WriteLine(navn);
Console.WriteLine("========================================");
Console.WriteLine("========================================");
Console.WriteLine("|               Alder:                  |");
Console.WriteLine(alder + " år");
Console.WriteLine("========================================");
if (inkluderInteresser == "ja")
{
    Console.WriteLine("========================================");
    Console.WriteLine("|           Interesser:                 |");
    Console.WriteLine(interesser);
    Console.WriteLine("========================================");
}
Console.WriteLine("Klik på en vilkårlig tast når du er færdig med at brugeprogrammet...");
Console.ReadKey();




/*
    Console.SetCursorPosition(5, 1); //Sætter cursorens start position.

    string StrengVariabel = "Blablabla"; //En streng er det samme som en tekst.
    int IntegerVariabel = 0; //En Integer er et Heltal
    double DoubleVariable = 0.5; //En double er et komma-tal
    bool ErEnBoolVariabel = true; //En bool kan have 2 værdier. true eller false.    

    Console.ReadLine(); //Læser brugeren input og returnere en streng. kan f.eks gemmes i en variabel.
    
 */