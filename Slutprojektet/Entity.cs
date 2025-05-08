
//Entity classen ska innehålla entitetens egenskaper, alltså dess HP och skada orsakad per attack.

public class Entity {
    public int hp;
    public int attack;
}

public class Bear : Entity {
    public Bear()
    {
        hp = 150;
        attack = Random.Shared.Next(8,35);
    }

    
}