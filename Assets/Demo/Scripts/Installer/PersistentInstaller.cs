using UnityEngine;

public class PersistentInstaller : PersistentInstallerBase
{
    public override void RegisterServices()
    {
        Services.Register(new HighScore());
    }
}
