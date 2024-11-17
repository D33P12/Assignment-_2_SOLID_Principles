using UnityEngine;
public class DoorController : MonoBehaviour
{
    [SerializeField] private float doorMoveRange = 3;
    private bool _isOpen = false;
    public void ToggleDoor()
    {
        _isOpen = !_isOpen;
        transform.position += (_isOpen ? Vector3.up : Vector3.down) * doorMoveRange;
        Debug.Log(_isOpen ? "Door Opened" : "Door Closed");
    }
}
