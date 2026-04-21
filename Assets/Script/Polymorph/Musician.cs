using UnityEngine;

public class Musician : MonoBehaviour
{
    [SerializeField]
    private MusicInstrument _musicInstrument;

    private void Start()
    {
        _musicInstrument.Play();
    }
}
