using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public void OpenDoor()
    {
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    public void Interact()
    {
        OpenDoor();
    }
}
