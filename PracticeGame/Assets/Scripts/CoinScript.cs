using UnityEngine;
public class CoinScript :MonoBehaviour, IInteractable
{
    private IScoreSystem _scoreSystem;
    private void Start()
    {
        _scoreSystem = GameManager.Instance; 
    }
    public void Interact()
    { 
        GameManager.Instance.AddCoin(); 
        Destroy(gameObject);            
    }
}
