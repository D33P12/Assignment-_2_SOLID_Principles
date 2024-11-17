using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour ,IScoreSystem
{ 
    //Single Responsibility: Manages game state like health, score, coins, game over/completion.
    //Interface Segregation: Implements IScoreSystem for score-related things.
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject gameCanvas;
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
        Debug.Log($"Score added: {_score}");
    }
    public void AddCoin()
    {
        _coins++;                
        AddScore(10);
        Debug.Log($"Score added: {_score} : Total Coins: {_coins}");
    }
    public int GetScore() => _score;
    public void DecreaseHealth(int amount)
    {
        _health -= amount;
        Debug.Log($"Health: {_health}");
        if (_health <= 0)
        {
            GameOver();
        }
    }
    public void IncreaseHealth(int amount)
    {
        _health += amount;
        Debug.Log($"Health: {_health}");
    }
    public void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f; 
        gameOverCanvas?.SetActive(true);
        Debug.Log("Game Over");
    }
    public void GameComplete()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f; 
        gameCanvas?.SetActive(true);
        Debug.Log("Game complete");
    }
    public void RestartGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        _health = 100;
        _score = 0;
        _coins = 0;
    }
}
