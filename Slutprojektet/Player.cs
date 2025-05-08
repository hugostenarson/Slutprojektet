using System.Reflection.Metadata.Ecma335;


//Player-classen innehåller dina egenskaper som spelare, t.ex. HP och attack.

public class playerAttributes {
    public int hp;
}

public class Player : playerAttributes {
    public Player() {
        hp = 100;
    }

public static int GetNextGuess() 
{
    int guess;
    //Läs in och kontrollerar att användar-input är ett heltal mellan 1 och 10.
    while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 10) {
        Console.WriteLine("Skriv endast heltal mellan 1 och 10!");
    }
    return guess;
}

    public void Attack(Entity entity)
    {
        if (hp <= 0)
        {
            return; //En död spelare kan inte attackera
        }
        entity.hp -= Random.Shared.Next(15,80);

        if (entity.hp < 0) 
        {
            entity.hp = 0;
        }
        System.Console.WriteLine($"Du slår tillbaka och träffar björnen! Den har nu {entity.hp} HP kvar.");
    }
}
