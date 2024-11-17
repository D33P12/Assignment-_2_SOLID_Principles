using UnityEngine;
public class GameManager : MonoBehaviour ,IScoreSystem
{ 
    public static GameManager Instance { get; private set; }
    private int Health = 100;
    private int Coins = 0;
    private int score = 0;
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
    public void AddScore(int amount)
    {
        score += amount; 
    }
    public void AddCoin()
    {
        Coins++;                
        AddScore(10);
        Debug.Log($"Score added: {score} : Total Coins: {Coins}");
    }
    public int GetScore()
    {
        return score;
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
