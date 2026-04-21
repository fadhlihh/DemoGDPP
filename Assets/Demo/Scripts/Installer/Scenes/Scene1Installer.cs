using UnityEngine;

public class Scene1Installer : SceneInstallerBase
{
    public override void RegisterServices()
    {
        Services.Register(new ScoreManager());
    }
}
