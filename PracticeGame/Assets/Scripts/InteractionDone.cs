using UnityEngine;
public class InteractionDone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IInteractable>(out var interactable))
        {
            interactable.Interact();
        }
        else if (other.TryGetComponent<InteractFoundation>(out var interactableFoundation))
        {
            interactableFoundation.Interact(GameManager.Instance);
        }
    }
}
