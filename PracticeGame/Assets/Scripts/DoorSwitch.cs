using UnityEngine;
public class DoorSwitch : InteractFoundation
{
    [SerializeField] private DoorController door;

    public override void Interact(GameManager gameManager)
    {
        if (door != null)
        {
            door.ToggleDoor();
        }
        else
        {
            Debug.LogError("No DoorController assigned to the switch!");
        }
    }
}
