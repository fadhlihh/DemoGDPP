using UnityEngine;

public abstract class MusicInstrument : MonoBehaviour
{
    [SerializeField]
    private string _name;

    public abstract void Play();
}
