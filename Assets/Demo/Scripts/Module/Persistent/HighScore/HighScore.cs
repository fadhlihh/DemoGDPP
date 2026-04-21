using UnityEngine;

public class HighScore
{
    public int Score { get; private set; }

    public void SetHighScore(int score)
    {
        Score = score;
        GlobalEventBus.Publish<UpdateHighScoreEvent>(new UpdateHighScoreEvent(Score));
    }
}
