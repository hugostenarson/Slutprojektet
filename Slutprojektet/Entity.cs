
//Entity classen ska innehålla entitetens egenskaper, alltså dess HP och skada orsakad per attack.

public class Entity {
    public int hp;
    public int minAttack;
    public int maxAttack;


    public void Attack(Player player)
    {
        if (hp <= 0)
        {
            return; //En död entitet kan inte heller attackera.
        }
        player.hp -= Random.Shared.Next(minAttack,maxAttack);
        if (player.hp < 0)
        {
            player.hp = 0;
        }
        System.Console.WriteLine($"Björnen attackerar dig! Du har nu {player.hp} HP kvar.");
        
    }
}

public class Bear : Entity {
    public Bear()
    {
        hp = 150;
        minAttack = 8;
        maxAttack = 35;
    }

    
}