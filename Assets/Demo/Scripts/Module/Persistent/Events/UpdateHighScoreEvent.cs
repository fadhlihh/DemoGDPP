using UnityEngine;

public struct UpdateHighScoreEvent
{
    public int Score { get; private set; }

    public UpdateHighScoreEvent(int score)
    {
        Score = score;
    }
}
