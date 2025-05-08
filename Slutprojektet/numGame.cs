
public class NumGame {

//Entiteten gömmer sig bakom ett slumpmässigt heltal mellan 1 och 10. 
public int entityNum = Random.Shared.Next(1, 11);
public int guessCount = 5;



public bool StartGuessing()
{
    Console.WriteLine($"Gissa ett heltal mellan 1 och 10. Du har totalt {guessCount} gissningar.");




    while (guessCount > 0)
    {
        int guess;
        //Läs in och kontrollerar att användar-input är ett heltal mellan 1 och 10.
        while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 10) {
            Console.WriteLine("Skriv endast heltal mellan 1 och 10!");
        }

        if (guess == entityNum)
        {
            System.Console.WriteLine("Du gissade rätt! Nu kommer entiteten, det är en björn! Gör dig redo för att slåss.");
            return true;
        }

        if (guess != entityNum)
        {
            guessCount -= 1;
            if (guessCount > 1)
            {
                System.Console.WriteLine($"Fel! Du har {guessCount} gissningar kvar, gissa igen.");
            }

            else if (guessCount == 1)
            {
                System.Console.WriteLine($"Du har {guessCount} gissning kvar. Sista chansen nu...");
            }

            else //Sista gissningen
            {

                if (guessCount != entityNum) //Game over om sista gissningen är fel
                {
                    System.Console.WriteLine("Slut på gissningar, nu dör du...");
                    System.Console.WriteLine("Tryck på valfri knapp för att \"passera till andra sidan\".");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }

        }

    }
    return false;
}
Bear bear = new();
Player player = new();

public void PlayerAttack()
{
    if (player.hp <= 0)
    {
        return; //En död spelare kan inte attackera
    }

    bear.hp -= player.attack;
    if (bear.hp < 0) 
    {
        bear.hp = 0;
    }
    System.Console.WriteLine($"Du slår tillbaka och träffar björnen! Den har nu {bear.hp} HP kvar.");
}

public void EntityAttack()
{
      if (bear.hp <= 0)
    {
        return; //En död entitet kan inte heller attackera.
    }
    player.hp -= bear.attack;
    if (player.hp < 0)
    {
        player.hp = 0;
    }
    System.Console.WriteLine($"Björnen attackerar dig! Du har nu {player.hp} HP kvar.");
}

public void Fight()
{
    while (bear.hp > 0 && player.hp > 0)
    {
        Thread.Sleep(4000);
        System.Console.WriteLine("");
        EntityAttack();
        Thread.Sleep(2000);
        PlayerAttack();
        // player.hp = 0;
    }
    if (bear.hp == 0)
    {
        System.Console.WriteLine("");
        Thread.Sleep(3000);
        System.Console.WriteLine("Grattis, du vinner! Du lyckades döda en björn med dina bara händer, inte illa.");
        System.Console.WriteLine("Tryck på valfri knapp för att ta dig härifrån.");
        Console.ReadKey();
        System.Environment.Exit(0);
    }
    
    if (player.hp == 0)
    {
        System.Console.WriteLine("");
        Thread.Sleep(2000);
        System.Console.WriteLine("Björnen var för stark. Du känner hur livet sakta rinner ur dig medan björnen börjar glufsa i sig dina inälvor...");
        System.Console.WriteLine("Tryck på valfri knapp för att avsluta ditt lidande.");
        Console.ReadKey();
        System.Environment.Exit(0);
    }
}

}