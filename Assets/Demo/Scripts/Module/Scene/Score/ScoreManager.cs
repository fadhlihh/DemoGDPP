using System;
using UnityEngine;

public class ScoreManager : IInitializable, IDisposable
{
    public int Score { get; private set; }

    private HighScore _highScore;

    public void Initialize()
    {
        GameContext.SceneEvents.Subscribe<AddScoreEvent>(AddScore);
        GameContext.SceneEvents.Subscribe<SubtractScoreEvent>(SubtractScore);
        if (!GameContext.PersistentServices.TryGet<HighScore>(out _highScore))
        {
            Debug.LogError("Module not found!");
        }
        GameContext.SceneEvents.Subscribe<SaveHighScoreEvent>(SaveHighScore);
    }

    public void Dispose()
    {
        GameContext.SceneEvents.Unsubscribe<AddScoreEvent>(AddScore);
        GameContext.SceneEvents.Unsubscribe<SubtractScoreEvent>(SubtractScore);
        GameContext.SceneEvents.Unsubscribe<SaveHighScoreEvent>(SaveHighScore);
    }

    public void AddScore(AddScoreEvent eventData)
    {
        Score = Score + 1;
        GameContext.SceneEvents.Publish<UpdateScoreEvent>(new UpdateScoreEvent(Score));
    }


    public void SubtractScore(SubtractScoreEvent eventData)
    {
        Score = Score - 1;
        GameContext.SceneEvents.Publish<UpdateScoreEvent>(new UpdateScoreEvent(Score));
    }

    public void SaveHighScore(SaveHighScoreEvent eventData)
    {
        _highScore.SetHighScore(Score);
    }
}
