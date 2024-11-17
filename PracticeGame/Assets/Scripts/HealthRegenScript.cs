public class HealthRegenScript : InteractFoundation
{
    public int healthIncrease = 10;
    //Single Responsibilty : because it is only focusing on health regeneration
    //Open-Closed: Can easily extend to add more effects.
    public override void Interact(GameManager gameManager)
    {
        gameManager.IncreaseHealth(healthIncrease);
        Destroy(gameObject);
    }
}
