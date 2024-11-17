using UnityEngine;
public class DeadEndScript : InteractFoundation
{
    public float initialSpeed = 4f; 
    public float speedIncrement = 1.5f; 
    public float interval = 11f; 
    private float _currentSpeed;
    private float _timeSinceLastIncrease;
    void Start()
    {
        _currentSpeed = initialSpeed; 
        _timeSinceLastIncrease = 0f; 
    }
    void Update()
    {
        transform.Translate(-Vector3.right * (_currentSpeed * Time.deltaTime));
        _timeSinceLastIncrease += Time.deltaTime;
        if (_timeSinceLastIncrease >= interval)
        {
            _currentSpeed += speedIncrement; 
            _timeSinceLastIncrease = 0f;
        }
    }
    public override void Interact(GameManager gameManager)
    {
        gameManager.GameOver();
    }
}
