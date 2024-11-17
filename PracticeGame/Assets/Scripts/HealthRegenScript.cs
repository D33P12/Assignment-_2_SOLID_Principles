public class HealthRegenScript : InteractFoundation
{
    public int healthIncrease = 10;
    public override void Interact(GameManager gameManager)
    {
        GameManager.Instance.IncreaseHealth(healthIncrease);
        Destroy(gameObject);
    }
}
