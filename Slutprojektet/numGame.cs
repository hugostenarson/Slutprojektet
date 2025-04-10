public class numGame {

public int entityNum = Random.Shared.Next(1, 10);
public int guessCount = 3;

private string userGuess = Console.ReadLine();
// public string enterUserGuess()
// {
//     return userGuess;

// }
public void startGuessing()
{
Console.WriteLine($"Gissa ett nummer från 1 till 10. Du har {guessCount} gissningar kvar.");
while (guessCount > 0)
{


int guess = int.Parse(Console.ReadLine());

if (guess == entityNum)
{
    System.Console.WriteLine("Du gissade rätt! Nu kommer entiteten, gör dig redo för att slåss.");
}

if (guess != entityNum) {
    guessCount -= 1;
    if (guessCount > 1) {
    System.Console.WriteLine($"Fel! Du har {guessCount} gissningar kvar, gissa igen.");
    }
    if (guessCount == 1) {
        System.Console.WriteLine($"Du har {guessCount} gissning kvar. Sista chansen nu...");
    }
    if (guessCount <= 0) {
        System.Console.WriteLine("Åh nej, nu dödar den dig!");
    }
}

}

}



}