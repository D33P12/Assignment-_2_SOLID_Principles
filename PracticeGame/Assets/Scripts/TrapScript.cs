public class TrapScript : InteractFoundation
{
    public int damage = 15;
    //dependency inversion : because it is dependent on the game manager
    //Open-Closed: Can easily add more effects.
    public override void Interact(GameManager gameManager)
    {
        gameManager.DecreaseHealth(damage);
    }
}
