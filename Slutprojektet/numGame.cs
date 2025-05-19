
public class NumGame
{

    //Entiteten gömmer sig bakom ett slumpmässigt heltal mellan 1 och 10. 
    public int entityNum = Random.Shared.Next(1, 11);
    private int guessCount = 5;



    private Entity getEntity;

    public void ChosenEntity()
    {
        List<Entity> entities = new List<Entity>
{
    new Bear(), new Wolf(), new Serpent(), new Tiger()
};
        int randomEntity = Random.Shared.Next(entities.Count);
        getEntity = entities[randomEntity];
        // System.Console.WriteLine($"Entiteten är en {getEntity.name}"!);
    }

    public bool StartGuessing()
    {
        Console.WriteLine($"Gissa ett heltal mellan 1 och 10. Du har totalt {guessCount} gissningar.");




        while (guessCount > 0)
        {
        int guess = Player.GetNextGuess();

        if (guess == entityNum)
        {
            System.Console.WriteLine($"Du gissade rätt! Nu kommer entiteten, det är en {getEntity.name}! Gör dig redo för att slåss.");
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
            System.Console.WriteLine($"Du har slut på gissningar och entiteten träder fram. Det är en {getEntity.name}! Nu äter den upp dig...");
            System.Console.WriteLine("Tryck på valfri knapp för att \"passera till andra sidan\".");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
    }

}

    }
    return false;
}

Player player = new();





public void Fight()
{
    while (getEntity.hp > 0 && player.hp > 0)
    {
        Thread.Sleep(3000);
        System.Console.WriteLine("");
        getEntity.Attack(player);
        Thread.Sleep(2000);
        player.Attack(getEntity);
    }
    if (getEntity.hp == 0)
    {
        System.Console.WriteLine("");
        Thread.Sleep(3000);
        System.Console.WriteLine($"Grattis, du vinner! Du lyckades döda en {getEntity.name} med dina bara händer, inte illa.");
        System.Console.WriteLine("Tryck på valfri knapp för att ta dig härifrån.");
        Console.ReadKey();
        System.Environment.Exit(0);
    }

    if (player.hp == 0)
    {
        System.Console.WriteLine("");
        Thread.Sleep(2000);
        if (getEntity is Bear)
        {
            System.Console.WriteLine("Björnen var för stark. Du känner hur livet sakta rinner ur dig medan björnen börjar glufsa i sig dina inälvor...");
        }
        else if (getEntity is Wolf)
        {
            System.Console.WriteLine("Vargen var alldeles för snabb. Du känner hur blodet forsar ut när vargen sliter ut strupen på dig med tänderna...");
        }

        else
        {
            System.Console.WriteLine("Du känner hur ormens gift börjar verkar. Du blir alldeles stel och ser i ögonvrån hur ormen närmar sig...");
        }

        System.Console.WriteLine("Tryck på valfri knapp för att avsluta ditt lidande.");
        Console.ReadKey();
        System.Environment.Exit(0);
    }
}

}