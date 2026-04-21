using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private InputManager _inputManager;

    private int _score;

    private void OnEnable()
    {
        // Subscribe/Listen
        // _inputManager.OnAddScoreAction += AddScore;
        // _inputManager.OnAddScoreEvent.AddListener(AddScore);
    }

    public void AddScore(int scoreToAdd)
    {
        _score = _score + scoreToAdd;
    }

    private void OnDisable()
    {
        // Unsubscribe/Unlisten
        // _inputManager.OnAddScoreAction -= AddScore;
        // _inputManager.OnAddScoreEvent.RemoveListener(AddScore);
    }
}
