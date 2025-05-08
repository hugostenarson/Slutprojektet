
//Entity classen ska innehålla entitetens egenskaper, som dess HP och skada den orsakar per attack.

public class Entity {
    public string name = "";
    public int hp;
    public int attack;
}

public class Bear : Entity {
    public Bear()
    {
        name = "Ben";
        hp = 150;
        attack = Random.Shared.Next(15,35);
    }

    
}