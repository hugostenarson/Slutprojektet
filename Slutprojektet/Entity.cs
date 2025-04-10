
//Entity classen ska innehålla entitetens egenskaper, som dess HP och skada den orsakar per attack.

public class Entity {
    public string Name;
    public int HP;
    public int Attack;
}

public class Bear : Entity {
    public Bear()
    {
        Name = "Ben";
        HP = 150;
        Attack = Random.Shared.Next(15,35);
    }

    
}