//Player-classen innehåller dina egenskaper som spelare, t.ex. HP och attack.

public class playerAttributes {
    public int playerHP;
    public int playerAttack;
}

public class Player : playerAttributes {
    public Player() {
        playerHP = 75;
    }
}