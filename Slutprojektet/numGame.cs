
public class NumGame {

//Entiteten gömmer sig bakom ett slumpmässigt nummer från 1 till 10. 
public int entityNum = Random.Shared.Next(1, 11);
public int guessCount = 5;



public bool StartGuessing()
{
    Console.WriteLine($"Gissa ett nummer från 1 till 10. Du har totalt {guessCount}.");




    while (guessCount > 0)
    {
        if (!int.TryParse(Console.ReadLine(), out int guess)) {
            Console.WriteLine("Skriv endast siffror mellan 1 och 10!");
        }
        // int guess = int.Parse(Console.ReadLine());

        if (guess == entityNum)
        {
            System.Console.WriteLine("Du gissade rätt! Nu kommer entiteten, gör dig redo för att slåss.");
            return true;
        }

        if (guess != entityNum)
        {
            guessCount -= 1;
            if (guessCount > 1)
            {
                System.Console.WriteLine($"Fel! Du har {guessCount} gissningar kvar, gissa igen.");
            }

            if (guessCount == 1)
            {
                System.Console.WriteLine($"Du har {guessCount} gissning kvar. Sista chansen nu...");
            }

            if (guessCount <= 0)
            {

                if (guessCount != entityNum)
                {
                    System.Console.WriteLine("Fel ännu igen, nu dör du...");
                }
            }

        }

    }
    return false;
}
Bear ben = new();
Player player = new();

public void playerAttack() {

    ben.hp -= player.attack;
    System.Console.WriteLine($"Du går till attack och träffar entiteten! Entiteten har nu {ben.hp} kvar.");
}

public void entityAttack() {
    player.hp -= ben.attack;
    System.Console.WriteLine($"Entiteten attackerar dig! Du har nu {player.hp} HP kvar.");
}

public void Fight() {
entityAttack();
Thread.Sleep(2000);
playerAttack();
}

}