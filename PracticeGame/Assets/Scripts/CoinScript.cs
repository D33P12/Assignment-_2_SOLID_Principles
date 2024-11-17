using UnityEngine;

public class CoinScript : InteractFoundation
{
    public override void Interact(GameManager gameManager)
    {
        GameManager.Instance.AddCoin();
        Destroy(gameObject);
    }
}
