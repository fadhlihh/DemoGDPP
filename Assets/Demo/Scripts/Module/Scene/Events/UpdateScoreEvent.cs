using UnityEngine;

public struct UpdateScoreEvent
{
    public int Score { get; private set; }

    public UpdateScoreEvent(int score)
    {
        Score = score;
    }
}
