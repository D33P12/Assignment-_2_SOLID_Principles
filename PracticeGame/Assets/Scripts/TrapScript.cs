public class TrapScript : InteractFoundation
{
    public int damage = 15;
    public override void Interact(GameManager gameManager)
    {
        gameManager.DecreaseHealth(damage);
    }
}
