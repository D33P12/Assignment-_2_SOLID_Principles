using UnityEngine;
public class InteractionDone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //this script will be on the player 
        //I am using two ways to interact 
        //interface
        if (other.TryGetComponent<IInteractable>(out var interactable))
        {
            interactable.Interact();
        }
        //abstract interaction
        else if (other.TryGetComponent<InteractFoundation>(out var interactableFoundation))
        {
            interactableFoundation.Interact(GameManager.Instance);
        }
        //Single Responsibility: Handles interaction logic.
        //Open-Closed: Can add new interactions by extending IInteractable or InteractFoundation.
    }
}
