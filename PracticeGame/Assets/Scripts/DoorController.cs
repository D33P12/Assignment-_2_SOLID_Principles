using UnityEngine;
public class DoorController : MonoBehaviour
{
    [SerializeField] private float doorMoveRange = 3;
    private bool _isOpen = false;
    public void ToggleDoor()
    {
        _isOpen = !_isOpen;
        if (_isOpen)
        {
            Debug.Log("Open.");
            transform.position += Vector3.up * doorMoveRange;
        }
        else
        {
            Debug.Log("Closed.");
            transform.position -= Vector3.up * doorMoveRange;
        }
    }
}
