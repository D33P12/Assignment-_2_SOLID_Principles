using UnityEngine;
public class GameManager : MonoBehaviour
{
    public int Health { get; set; } = 100;
    public static GameManager Instance { get; private set; }
    public int Coins { get; private set; } = 0;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    public void AddCoin()
    {
        Coins++;
        Debug.Log($"Coins:{Coins}");
    }
    public void DecreaseHealth(int amount)
    {
        Health -= amount;
        Debug.Log($"Health: {Health}");
        if (Health <= 0)
        {
            Debug.Log("Player is dead.");
        }
    }
    public void IncreaseHealth(int amount)
    {
        Health += amount;
        Debug.Log($"Health: {Health}");
    }
}
