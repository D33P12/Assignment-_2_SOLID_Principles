using UnityEngine;
public abstract class InteractFoundation : MonoBehaviour
{
    //Single Responsibility: it is the base for all the interactive objects in the game(most of it ) 
    public abstract void Interact(GameManager gameManager);
}
