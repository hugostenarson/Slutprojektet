using System.Reflection.Metadata.Ecma335;


//Player-classen innehåller dina egenskaper som spelare, t.ex. HP och attack.

public class playerAttributes {
    public int HP;
    public int Attack;
}

public class Player : playerAttributes {
    public Player() {
        HP = 75;
        Attack = Random.Shared.Next(15,80);
    }

    
}