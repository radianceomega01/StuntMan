
public abstract class PlayerState
{
    protected Player player;
    protected PlayerActions playerActions;
    public PlayerState(Player player)
    {
        this.player = player;
        playerActions = player.GetPlayerActions();
    }

    public abstract void OnEnter();
    public abstract void Process();
    public abstract void PhysicsProcess();
}
