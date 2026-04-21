using UnityEngine;

public class Scene2Installer : SceneInstallerBase
{
    public override void RegisterServices()
    {
        Services.Register(new ScoreManager());
    }
}
