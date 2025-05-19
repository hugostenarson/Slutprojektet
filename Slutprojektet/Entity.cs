
//Entity classen ska innehålla entitetens egenskaper, alltså dess HP och skada orsakad per attack.
public class Entity {
    public int hp;
    public int minAttack;
    public int maxAttack;
    public string name;


    public void Attack(Player player)
    {
        if (hp <= 0)
        {
            return; //En död entitet kan inte attackera.
        }
        player.hp -= Random.Shared.Next(minAttack,maxAttack); //Spelaren tar en slumpmässig mängd i skada slumpat från entitetens svagaste och starkaste möjliga attack.
        if (player.hp < 0)
        {
            player.hp = 0;
        }
        System.Console.WriteLine($"Du blir attackerad! Du har nu {player.hp} HP kvar.");
        
    }
}

public class Bear : Entity {
    public Bear()
    {
        name = "björn";
        hp = 150;
        minAttack = 8;
        maxAttack = 35;
    }
}

public class Wolf : Entity {
    public Wolf()
    {
        name = "varg";
        hp = 100;
        minAttack = 10;
        maxAttack = 40;
    }
}

public class Serpent : Entity
{
    public Serpent()
    {
        name = "orm";
        hp = 75;
        minAttack = 15;
        maxAttack = 60;
    }
}

public class Tiger : Entity
{
    public Tiger()
    {
        name = "tiger";
        hp = 100;
        minAttack = 20;
        maxAttack = 80;
    }
}