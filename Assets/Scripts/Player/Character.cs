
using System.Collections.Generic;

public enum PlayerState
{
    Influence,
    EndTurn,
    CheckInfluence
}
public class Character
{
    public int playerID;
    public PlayerState playerState;

    public void Next()
    {
        playerState = (PlayerState)(((int)playerState + 1) % 3);
    }
    public List<FootItem> footItems { get; set; }

    public Character(List<FootItem> _footItems)
    {
        this.playerState = PlayerState.Influence;
        footItems = _footItems;
    }

}
