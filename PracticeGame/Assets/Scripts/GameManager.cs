using UnityEngine;
public class GameManager : MonoBehaviour ,IScoreSystem
{ 
    public static GameManager Instance { get; private set; }
    private int _health = 100;
    private int _coins = 0;
    private int _score = 0;
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
        _score += amount; 
    }
    public void AddCoin()
    {
        _coins++;                
        AddScore(10);
        Debug.Log($"Score added: {_score} : Total Coins: {_coins}");
    }
    public int GetScore()
    {
        return _score;
    }
    public void DecreaseHealth(int amount)
    {
        _health -= amount;
        Debug.Log($"Health: {_health}");
        if (_health <= 0)
        {
            Debug.Log("Player is dead.");
        }
    }
    public void IncreaseHealth(int amount)
    {
        _health += amount;
        Debug.Log($"Health: {_health}");
    }
}
