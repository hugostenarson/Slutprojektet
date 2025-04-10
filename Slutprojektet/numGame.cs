
public class numGame {

public int entityNum = Random.Shared.Next(1, 10);
public int guessCount = 5;



public void startGuessing()
{
Console.WriteLine($"Gissa ett nummer från 1 till 10. Du har totalt {guessCount}.");

while (guessCount > 0)
{
int guess = int.Parse(Console.ReadLine());

if (guess == entityNum)
{
    System.Console.WriteLine("Du gissade rätt! Nu kommer entiteten, gör dig redo för att slåss.");
}

if (guess != entityNum) {
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
        System.Console.WriteLine("Fel ännu igen, nu dör du...");
    }
}

}
}
Bear ben = new();
Player player = new();

public void playerAttack() {

    ben.HP -= player.Attack;
    System.Console.WriteLine($"Du går till attack och träffar entiteten! Entiteten har nu {ben.HP} kvar.");
}

public void entityAttack() {
    player.HP -= ben.Attack;
    System.Console.WriteLine($"Entiteten attackerar dig! Du har nu {player.HP} HP kvar.");
}

public void Fight() {
entityAttack();
Thread.Sleep(2000);
playerAttack();
}

}