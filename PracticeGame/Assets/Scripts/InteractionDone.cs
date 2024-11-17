using UnityEngine;

public class InteractionDone : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<InteractFoundation>(out var interactable))
        {
            interactable.Interact(gameManager);
        }
    }
}
