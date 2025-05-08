using System.Reflection.Metadata.Ecma335;


//Player-classen innehåller dina egenskaper som spelare, t.ex. HP och attack.

public class playerAttributes {
    public int hp;
    public int attack;
}

public class Player : playerAttributes {
    public Player() {
        hp = 100;
        attack = Random.Shared.Next(15,80);
    }

}
