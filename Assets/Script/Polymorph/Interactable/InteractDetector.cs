using UnityEngine;

public class InteractDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IInteractable>() != null)
        {
            other.GetComponent<IInteractable>().Interact();
        }
    }
}
