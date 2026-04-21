using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour, IInitializable, IDisposable
{
    [SerializeField]
    private TMP_Text _scoreText;
    [SerializeField]
    private TMP_Text _highScoreText;

    private HighScore _highScore;

    public void Initialize()
    {
        GameContext.SceneEvents.Subscribe<UpdateScoreEvent>(UpdateScoreUI);
        if (!GameContext.PersistentServices.TryGet<HighScore>(out _highScore))
        {
            Debug.LogError("Module not found!");
        }

        _highScoreText.text = $"High Score: {_highScore.Score}";

        GlobalEventBus.Subscribe<UpdateHighScoreEvent>(UpdateHighScoreUI);
    }

    public void Dispose()
    {
        GameContext.SceneEvents.Unsubscribe<UpdateScoreEvent>(UpdateScoreUI);
    }

    public void UpdateScoreUI(UpdateScoreEvent eventData)
    {
        _scoreText.text = eventData.Score.ToString();
    }

    public void UpdateHighScoreUI(UpdateHighScoreEvent eventData)
    {
        _highScoreText.text = $"High Score: {eventData.Score}";
    }

    public void OnAddScore()
    {
        GameContext.SceneEvents.Publish<AddScoreEvent>(new AddScoreEvent());
    }

    public void OnSubtractScore()
    {
        GameContext.SceneEvents.Publish<SubtractScoreEvent>(new SubtractScoreEvent());
    }

    public void OnSaveHighScore()
    {
        GameContext.SceneEvents.Publish<SaveHighScoreEvent>(new SaveHighScoreEvent());
    }
}
