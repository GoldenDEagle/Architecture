using Assets.Codebase.Infrastructure.Initialization;
using UnityEngine;

namespace Assets.Codebase.Utils.GOComponents
{
    /// <summary>
    /// Used to initialize game structure outside Bootstrapper scene.
    /// </summary>
    public class SceneContext : MonoBehaviour
    {
        [SerializeField] GameLaunchParams _gameLaunchParams;

        private void Awake()
        {
            if (GameStructure.IsGameInitialized) return;

            GameStructure structure = new GameStructure(null, _gameLaunchParams);
        }
    }
}