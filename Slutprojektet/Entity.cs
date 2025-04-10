//Entity classen ska innehålla entitetens egenskaper, som dess HP och skada den orsakar per attack.
public class Entity {
    public string entityName;
    public int entityHP;
    public int entityAttack;
}

public class Bear : Entity {
    public Bear()
    {
        entityName = "Ben";
        entityHP = 150;
    }
}