using System;

Console.WriteLine("Brugerdefineret gæt et tal spil 12/3/25");
Console.WriteLine("Hvad skal være det mindste tal computeren kan tænke på?");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hvad skal være det højeste tal computeren kan tænke på?");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Skal der være hints om hvor stort nummeret er? (Skriv 'true' eller 'false')");
bool hints = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Hvor mange forsøg skal der gives?");
int tries = Convert.ToInt32(Console.ReadLine());
int avg = min + max / 2;
Random random = new Random();
int result = random.Next(min, max);
Console.WriteLine(result);

for (int i = 0; i < tries; i++)
{
    Console.WriteLine("Gæt på et tal fra " + min + " til " + max + ": ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (i == 0)
    {

        if (guess == result)
        {
            Console.WriteLine("Du gættede rigtigt!");
            break;
        }

        else if (hints == true)
        {
            Console.WriteLine("Du gættede ikke rigtigt. Hint: Udsagnet 'tallet er større end " + (max/2) + "' er " + (result<(max/2)));
        }

        else
        {
            Console.WriteLine("Du gættede ikke rigtigt.");
        }
    }
    else if(i == tries)
    {
        Console.WriteLine("Du gættede ikke rigtigt. Svaret var " + result + ".");
    }


    else
    {
        if (guess == result)
        {
            Console.WriteLine("Du gættede rigtigt denne gang!");
            break;
        }

        else if (hints == true)
        {
            Console.WriteLine("Du gættede ikke rigtigt. Husk at der stod '" + (result < (max / 2)) + "' før.");
        }

        else
        {
            Console.WriteLine("Du gættede ikke rigtigt (igen).");
        }
    }
}

Console.ReadKey();