using UnityEngine;

public class Key : MonoBehaviour, IInteractable
{
    public void Pickup()
    {
        Destroy(gameObject);
    }

    public void Interact()
    {
        Pickup();
    }
}
